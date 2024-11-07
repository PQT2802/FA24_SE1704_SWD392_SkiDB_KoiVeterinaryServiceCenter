using KVSC.Application.Common.VnPayment;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class VnPaymentService : IVnPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _config;
        private readonly IWalletService _walletService;

        public VnPaymentService(IUnitOfWork unitOfWork, IConfiguration configuration, IWalletService walletService)
        {
            _unitOfWork = unitOfWork;
            _config = configuration;
            _walletService = walletService;
        }

        public async Task<Result> CreatePaymentUrl(HttpContext context, double depositMoney, Guid userId)
        {
            if (depositMoney < 10000)
            {
                return Result.Failure(Error.Validation("Payment", "Deposit money must be larger than 10000"));
            }

            var tick = DateTime.Now.Ticks.ToString();
            var vnpay = new VnPayLibrary();

            string paymentBackReturnUrl = _config["VnPay:PaymentBackReturnUrl"];
            vnpay.AddRequestData("vnp_Version", _config["VnPay:Version"]);
            vnpay.AddRequestData("vnp_Command", _config["VnPay:Command"]);
            vnpay.AddRequestData("vnp_TmnCode", _config["VnPay:TmnCode"]);
            vnpay.AddRequestData("vnp_Amount", (depositMoney * 100).ToString()); // Amount in cents
            vnpay.AddRequestData("vnp_CreateDate", DateTime.Now.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", _config["VnPay:CurrCode"]);
            vnpay.AddRequestData("vnp_IpAddr", Utils.GetIpAddress(context));
            vnpay.AddRequestData("vnp_Locale", _config["VnPay:Locale"]);
            vnpay.AddRequestData("vnp_OrderInfo", "Payment for order");
            vnpay.AddRequestData("vnp_OrderType", "other");
            vnpay.AddRequestData("vnp_ReturnUrl", $"{paymentBackReturnUrl}?userId={userId}&depositMoney={depositMoney}");
            vnpay.AddRequestData("vnp_TxnRef", tick);

            var paymentUrl = vnpay.CreateRequestUrl(_config["VnPay:BaseUrl"], _config["VnPay:HashSecret"]);
            return Result.SuccessWithObject(new {Url = paymentUrl});
        }

        public async Task<Result> GetPaymentByUserIdAsync(Guid userId)
        {
            var result = await _unitOfWork.PaymentRepository.GetPaymentByUserIdAsync(userId);
            if (result == null || result.Count() == 0)
            {
                return Result.Failure(Error.NotFound("NoData", "No payment record!!!!"));
            }
            return Result.SuccessWithObject(result);
        }

        public async Task<Result> PaymentExecute(IQueryCollection collections, Guid userId, double depositMoney)
        {
            var vnpay = new VnPayLibrary();
            foreach (var (key, value) in collections)
            {
                if (!string.IsNullOrEmpty(key) && key.StartsWith("vnp_"))
                {
                    vnpay.AddResponseData(key, value.ToString());
                }
            }

            var vnp_SecureHash = collections["vnp_SecureHash"];
            bool isValidSignature = vnpay.ValidateSignature(vnp_SecureHash, _config["VnPay:HashSecret"]);
            if (!isValidSignature)
            {
                return Result.Failure(Error.Failure("Transaction", "Transaction failed due to invalid signature"));
            }

            string vnp_ResponseCode = vnpay.GetResponseData("vnp_ResponseCode");
            if (vnp_ResponseCode == "00")  // "00" indicates a successful transaction
            {
                // Update wallet balance
                var walletUpdateResult = await _walletService.UpdateWalletBalanceAsync(userId, (decimal)depositMoney);
                if (!walletUpdateResult.IsSuccess)
                {
                    return Result.Failure(Error.Failure("WalletUpdate", "Failed to update wallet balance after payment."));
                }

                // Log transaction
                var transaction = new Transaction
                {
                    UserId = userId,
                    Amount = (decimal)depositMoney,
                    TransactionType = "Top-Up",
                    TransactionDate = DateTime.UtcNow
                };
                await _unitOfWork.TransactionRepository.AddTransactionAsync(transaction);

                return Result.SuccessWithObject(new { Message = "Transaction successful" });
            }
            else
            {
                return Result.Failure(Error.Failure("Transaction", $"Transaction failed with response code: {vnp_ResponseCode}"));
            }
        }

        public async Task<Result> UpdatePayment(Guid userId,Guid paymentId)
        {
            var wallet = await _unitOfWork.WalletRepository.GetWalletByUserIdAsync(userId);
            var payment = await _unitOfWork.PaymentRepository.GetByIdAsync(paymentId);
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(payment.AppointmentId);
           // var appointment = await _unitOfWork.AppointmentRepository.Get
            if (payment.TotalAmount > wallet.Amount)
            {
                return Result.Failure(Error.Failure("Transaction", $"Not enough money"));
            }
            wallet.Amount = wallet.Amount - payment.TotalAmount;
            payment.TotalAmountStatus = true;
            payment.Status = "Completed";
            appointment.Status = "Completed";
            await _unitOfWork.WalletRepository.UpdateAsync(wallet);
            await _unitOfWork.AppointmentRepository.UpdateAsync(appointment);
            var result = await _unitOfWork.PaymentRepository.UpdateAsync(payment);
            return Result.SuccessWithObject(new {Message =" Pay successfully"});
        }
    }
}

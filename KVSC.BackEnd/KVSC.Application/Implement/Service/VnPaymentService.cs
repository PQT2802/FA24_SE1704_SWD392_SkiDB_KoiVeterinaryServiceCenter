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

        public VnPaymentService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _config = configuration;
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
            return Result.SuccessWithObject(paymentUrl);
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
                // Create a new Payment record
                var payment = new Payment
                {
                    OrderId = Guid.NewGuid(), // Replace with the actual OrderId
                    SystemTransactionId = Guid.NewGuid(), // Replace with actual SystemTransactionId if available
                    TotalAmount = (decimal)depositMoney,
                    Tax = 0, // Add tax calculation if applicable
                    TransactionDate = DateTime.UtcNow
                };

                await _unitOfWork.PaymentRepository.AddPaymentAsync(payment);

                return Result.SuccessWithObject(new { Message = "Transaction successful", PaymentId = payment.Id });
            }
            else
            {
                return Result.Failure(Error.Failure("Transaction", $"Transaction failed with response code: {vnp_ResponseCode}"));
            }
        }
    }
}

using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class WalletService : IWalletService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITransactionService _transactionService;

        public WalletService(IUnitOfWork unitOfWork, ITransactionService transactionService)
        {
            _unitOfWork = unitOfWork;
            _transactionService = transactionService;
        }

        public async Task<Result> GetWalletBalanceAsync(Guid userId)
        {
            var wallet = await _unitOfWork.WalletRepository.GetWalletByUserIdAsync(userId);
            if (wallet == null)
            {
                return Result.Failure(Error.NotFound("WalletNotFound", "Wallet not found for the user."));
            }

            return Result.SuccessWithObject(new { Balance = wallet.Amount });
        }

        public async Task<Result> UpdateWalletBalanceAsync(Guid userId, decimal amount)
        {
            await _unitOfWork.WalletRepository.UpdateWalletBalanceAsync(userId, amount);
            return Result.SuccessWithObject(new { Message = "Wallet balance updated successfully" });
        }

        public async Task<Result> DepositPaymentAsync(Guid userId, Guid appointmentId, decimal depositAmount)
        {
            var wallet = await _unitOfWork.WalletRepository.GetWalletByUserIdAsync(userId);
            if (wallet == null || wallet.Amount < depositAmount)
            {
                return Result.Failure(Error.Validation("InsufficientFunds", "Insufficient funds in wallet."));
            }

            // Deduct deposit from wallet
            await _unitOfWork.WalletRepository.UpdateWalletBalanceAsync(userId, -depositAmount);

            // Log the transaction
            await _transactionService.AddTransactionAsync(new Transaction
            {
                UserId = userId,
                Amount = depositAmount,
                TransactionType = "Deposit",
                TransactionDate = DateTime.UtcNow
            });

            // Update Payment status in database if needed
            var payment = await _unitOfWork.PaymentRepository.GetPaymentByAppointmentIdAsync(appointmentId);
            if (payment != null)
            {
                payment.Deposit = depositAmount;
                payment.Status = true; // Update the status as required
                await _unitOfWork.PaymentRepository.UpdateAsync(payment);
            }

            return Result.SuccessWithObject(new { Message = "Deposit payment successfully made" });
        }

        public async Task<Result> TotalAmountPaymentAsync(Guid userId, Guid appointmentId, decimal totalAmount)
        {
            var wallet = await _unitOfWork.WalletRepository.GetWalletByUserIdAsync(userId);
            if (wallet == null || wallet.Amount < totalAmount)
            {
                return Result.Failure(Error.Validation("InsufficientFunds", "Insufficient funds in wallet."));
            }

            // Deduct remaining amount from wallet
            await _unitOfWork.WalletRepository.UpdateWalletBalanceAsync(userId, -totalAmount);

            // Log the transaction
            await _transactionService.AddTransactionAsync(new Transaction
            {
                UserId = userId,
                Amount = totalAmount,
                TransactionType = "Total Payment",
                TransactionDate = DateTime.UtcNow
            });

            // Update Payment status in database if needed
            var payment = await _unitOfWork.PaymentRepository.GetPaymentByAppointmentIdAsync(appointmentId);
            if (payment != null)
            {
                payment.TotalAmount = totalAmount;
                payment.Status = true; // Update the status as required
                await _unitOfWork.PaymentRepository.UpdateAsync(payment);
            }

            return Result.SuccessWithObject(new { Message = "Total amount payment successfully made" });
        }
    }
}

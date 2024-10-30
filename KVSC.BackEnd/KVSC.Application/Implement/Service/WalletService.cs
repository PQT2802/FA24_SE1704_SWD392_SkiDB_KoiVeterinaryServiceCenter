using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class WalletService : IWalletService
    {
        private readonly IUnitOfWork _unitOfWork;

        public WalletService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
    }
}

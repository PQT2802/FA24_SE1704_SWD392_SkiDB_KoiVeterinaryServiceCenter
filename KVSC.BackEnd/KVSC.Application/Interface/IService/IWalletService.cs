using KVSC.Application.KVSC.Application.Common.Result;
using System;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IWalletService
    {
        Task<Result> GetWalletBalanceAsync(Guid userId);
        Task<Result> UpdateWalletBalanceAsync(Guid userId, decimal amount);
        Task<Result> DepositPaymentAsync(Guid userId, Guid appointmentId, decimal depositAmount);
        Task<Result> TotalAmountPaymentAsync(Guid userId, Guid appointmentId, decimal totalAmount);
    }
}

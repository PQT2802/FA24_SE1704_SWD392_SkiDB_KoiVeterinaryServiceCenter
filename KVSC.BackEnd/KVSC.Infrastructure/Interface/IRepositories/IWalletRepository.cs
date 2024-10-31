using KVSC.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IWalletRepository : IGenericRepository<Wallet>
    {
        Task<Wallet> GetWalletByUserIdAsync(Guid userId);
        Task UpdateWalletBalanceAsync(Guid userId, decimal amount);
    }
}

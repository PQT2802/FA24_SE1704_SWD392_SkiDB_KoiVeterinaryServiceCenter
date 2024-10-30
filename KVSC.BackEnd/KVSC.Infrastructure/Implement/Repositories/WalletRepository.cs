using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class WalletRepository : GenericRepository<Wallet>, IWalletRepository
    {
        private readonly KVSCContext _context;
        public WalletRepository(KVSCContext context) : base(context) 
        {
            _context= context;
        }

        public async Task<Wallet> GetWalletByUserIdAsync(Guid userId)
        {
            return await _context.Wallets
                .FirstOrDefaultAsync(w => w.UserId == userId);
        }

        public async Task UpdateWalletBalanceAsync(Guid userId, decimal amount)
        {
            var wallet = await GetWalletByUserIdAsync(userId);
            if (wallet != null)
            {
                wallet.Amount += amount; // Update balance (can be positive or negative)
                await _context.SaveChangesAsync();
            }
        }
    }
}

using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(KVSCContext context) : base(context) { }

        public async Task<Cart> GetCartWithItemsAsync(Guid customerId)
        {
            return await _context.Carts
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Product)
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.PetService)
                .FirstOrDefaultAsync(c => c.CustomerId == customerId);
        }
    }


}

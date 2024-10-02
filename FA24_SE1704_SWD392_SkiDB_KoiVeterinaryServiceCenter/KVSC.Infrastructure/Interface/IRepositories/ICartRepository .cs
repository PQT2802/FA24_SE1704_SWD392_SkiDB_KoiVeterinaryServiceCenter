using KVSC.Domain.Entities;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        Task<Cart> GetCartWithItemsAsync(Guid? userId);

    }

}

using KVSC.Infrastructure.Interface.IRepositories;

namespace KVSC.Infrastructure.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IPetRepository PetRepository { get; }
        ICartRepository CartRepository { get; }
        int Complete();
    }
}

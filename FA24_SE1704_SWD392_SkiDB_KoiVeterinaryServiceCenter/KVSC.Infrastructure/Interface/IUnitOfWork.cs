using KVSC.Infrastructure.Interface.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IPetRepository PetRepository { get; }
        IProductRepository ProductRepository { get; }
        IFirebaseRepository FirebaseRepository { get; }
        IProductCategoryRepository ProductCategoryRepository { get; }
        int Complete();
    }
}

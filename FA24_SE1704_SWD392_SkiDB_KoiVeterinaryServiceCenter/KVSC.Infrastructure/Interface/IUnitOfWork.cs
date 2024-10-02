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
        IPetServiceRepository PetServiceRepository { get; }
        IPetServiceCategoryRepository PetServiceCategoryRepository { get; }
        int Complete();
    }
}

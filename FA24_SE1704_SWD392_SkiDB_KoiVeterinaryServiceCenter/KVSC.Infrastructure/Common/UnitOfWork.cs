using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Implement.Repositories;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KVSC.Infrastructure.KVSC.Infrastructure.Common
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly KVSCContext _context;

        public IUserRepository UserRepository { get; private set; }
        public IPetRepository PetRepository { get; private set; }
        public IPetServiceRepository PetServiceRepository { get; private set; }
        public IPetServiceCategoryRepository PetServiceCategoryRepository { get; private set; }
        public IComboServiceRepository ComboServiceRepository { get; private set; }
        public UnitOfWork(KVSCContext context)
        {
            _context = context;
            UserRepository = new UserRepository(_context);
            PetRepository = new PetRepository(_context);
            PetServiceRepository = new PetServiceRepository(_context);
            PetServiceCategoryRepository = new PetServiceCategoryRepository(_context);
            ComboServiceRepository = new ComboServiceRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

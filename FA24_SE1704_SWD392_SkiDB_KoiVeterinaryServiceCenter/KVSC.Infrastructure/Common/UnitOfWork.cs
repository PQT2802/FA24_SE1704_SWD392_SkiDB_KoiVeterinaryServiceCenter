﻿using KVSC.Infrastructure.DB;
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

        public UnitOfWork(KVSCContext context)
        {
            _context = context;
            UserRepository = new UserRepository(_context);

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

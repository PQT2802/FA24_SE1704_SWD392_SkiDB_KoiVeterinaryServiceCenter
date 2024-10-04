﻿using Google.Cloud.Storage.V1;
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
        public IProductRepository ProductRepository { get; private set; }
        public IFirebaseRepository FirebaseRepository { get; private set; }
        public IProductCategoryRepository ProductCategoryRepository { get; private set; }

        public UnitOfWork(KVSCContext context, StorageClient storageClient)
        {
            _context = context;
            UserRepository = new UserRepository(_context);
            PetRepository = new PetRepository(_context);
            ProductRepository = new ProductRepository(_context);
            FirebaseRepository = new FirebaseRepository(storageClient);
            ProductCategoryRepository = new ProductCategoryRepository(_context);
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

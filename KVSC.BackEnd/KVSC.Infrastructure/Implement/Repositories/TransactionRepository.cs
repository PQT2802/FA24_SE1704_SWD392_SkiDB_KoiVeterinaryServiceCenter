using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
{
    private readonly KVSCContext _context;
    public TransactionRepository(KVSCContext context) : base(context) 
    {
        _context = context;
    }

    public async Task AddTransactionAsync(Transaction transaction)
    {
        _context.Transactions.Add(transaction);
        await _context.SaveChangesAsync();
    }
}


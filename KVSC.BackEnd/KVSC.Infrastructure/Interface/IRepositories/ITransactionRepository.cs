using KVSC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        Task AddTransactionAsync(Transaction transaction);
    }
}

using KVSC.Application.Interface.IService;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddTransactionAsync(Transaction transaction)
        {
            await _unitOfWork.TransactionRepository.AddTransactionAsync(transaction);
        }
    }
}

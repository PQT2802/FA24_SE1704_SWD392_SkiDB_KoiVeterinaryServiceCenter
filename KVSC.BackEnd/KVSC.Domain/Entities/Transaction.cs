using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public Guid UserId { get; set; }  // Foreign key to User
        public decimal Amount { get; set; }
        public string TransactionType { get; set; } // Deposit, Payment, Top-Up
        public DateTime TransactionDate { get; set; }

        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Payment
{
    public class GetPayment
    {
        public Guid PaymentId { get; set; }
        public Guid AppointmentId { get; set; }
        public string ServiceName { get; set; }
        public Guid CustomerId { get; set; }
        public decimal BasePrice { get; set; }
        public decimal TravelCost { get; set; }
        public decimal Deposit { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }        
        public bool TotalAmountStatus { get; set;}
        public bool DepositStatus { get; set; }
    }
}

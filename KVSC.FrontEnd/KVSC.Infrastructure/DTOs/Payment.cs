using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public class Payment
    {
        public Extensions<CommonMessageData> Extensions { get; set; }
    }
    public class PaymentData 
    {
        public Guid AppointmentId { get; set; } // Foreign key to Order
        public decimal TotalAmount { get; set; }
        public decimal Deposit { get; set; }
        public bool totalAmountStatus { get; set; }
        public bool depositStatus { get; set; }
    }
}

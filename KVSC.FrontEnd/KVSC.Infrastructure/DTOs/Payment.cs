using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public class Payment
    {
        public Extensions<List<PaymentData>> Extensions { get; set; }
    }
    public class PaymentData : IPropertyNameProvider
    {
        public Guid PaymentId { get; set; }
        public Guid AppointmentId { get; set; }
        public string ServiceName { get; set; }
        public Guid CustomerId { get; set; }
        public decimal BasePrice { get; set; }
        public decimal TravelCost { get; set; }
        public decimal Deposit { get; set; }
        public decimal TotalAmount { get; set; }
        public bool TotalAmountStatus { get; set; }
        public bool DepositStatus { get; set; }
        public List<string> GetPropertyNames()
        {
            return new List<string> { nameof(ServiceName), nameof(BasePrice), nameof(TravelCost), nameof(Deposit), nameof(TotalAmount), nameof(TotalAmountStatus) };
        }
    }
}

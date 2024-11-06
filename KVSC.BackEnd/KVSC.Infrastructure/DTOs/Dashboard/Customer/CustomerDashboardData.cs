using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Customer
{
    public class CustomerDashboardData
    {
        public int TotalPets { get; set; }
        public int TotalAppointments { get; set; }
        public decimal TotalPayments { get; set; }

        public Dictionary<DateTime, int> MonthlyAppointments { get; set; }
        public Dictionary<DateTime, decimal> MonthlyPayments { get; set; }
    }
}

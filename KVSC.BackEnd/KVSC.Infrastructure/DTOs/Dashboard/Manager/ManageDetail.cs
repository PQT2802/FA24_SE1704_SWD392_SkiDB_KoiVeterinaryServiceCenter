using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Manager
{
    public class ManageDetail
    {
        public int TotalCustomers { get; set; }
        public int TotalVeterinarians { get; set; }
        public decimal TotalPayments { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Admin
{
    public class GetAdminDashboardResponse
    {
        public Extensions<GetAdminDashboardData> Extensions { get; set; }

    }
    public class GetAdminDashboardData
    {
        public int TotalUsers { get; set; }
        public int TotalCustomers { get; set; }
        public int TotalVeterinarians { get; set; }
        public int TotalStaff { get; set; }
        public int TotalManagers { get; set; }
        public decimal TotalPayments { get; set; }
    }
}


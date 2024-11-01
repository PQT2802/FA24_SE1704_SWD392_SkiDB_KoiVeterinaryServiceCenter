using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Admin
{
    public class AdminDashboardData
    {
        public List<TopVeterinarian> TopVeterinarians { get; set; }
        public List<TopService> BestServices { get; set; }
        public List<TopProduct> TopSellingProducts { get; set; }
    }
}

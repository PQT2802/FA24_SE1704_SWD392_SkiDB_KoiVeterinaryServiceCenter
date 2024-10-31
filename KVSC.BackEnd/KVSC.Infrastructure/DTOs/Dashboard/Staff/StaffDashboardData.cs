using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Staff
{
    public class StaffDashboardData
    {
        public List<ProductInStock> ProductsInStock { get; set; }
        public List<OrderDataDetail> RecentOrders { get; set; }
    }
}

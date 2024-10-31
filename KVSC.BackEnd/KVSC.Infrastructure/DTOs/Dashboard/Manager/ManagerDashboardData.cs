using KVSC.Infrastructure.DTOs.Dashboard.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Manager
{
    public class ManagerDashboardData
    {
        public ManageDetail ManageDetails { get; set; }
        public List<AppointmentDetail> AppointmentDetails { get; set; }
        public List<ServiceReportDetail> ServiceReportDetails { get; set; }
    }
}

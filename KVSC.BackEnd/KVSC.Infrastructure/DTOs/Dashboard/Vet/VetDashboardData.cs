using KVSC.Infrastructure.DTOs.Dashboard.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Vet
{
    public class VetDashboardData
    {
        public int TotalCustomers { get; set; }
        public int TotalAppointments { get; set; }

        public List<UpcomingAppointment> UpcomingAppointment { get; set; }
        public List<CompletedAppointment> CompletedAppointment { get; set; }
        public List<PendingAppointment> PendingAppointment { get; set; }
    }
}

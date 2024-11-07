using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Veterinarian
{
    public class GetVetDashboardResponse
    {
        public Extensions<GetVetDashboardData> Extensions { get; set; }

    }
    public class GetVetDashboardData
    {
        public int TotalCustomers { get; set; }
        public int TotalAppointments { get; set; }

        public List<UpcomingAppointment> UpcomingAppointment { get; set; }
        public List<CompletedAppointment> CompletedAppointment { get; set; }
        public List<PendingAppointment> PendingAppointment { get; set; }
    }

    public class UpcomingAppointment
    {
        public DateTime AppointmentDate { get; set; }
        public string CustomerName { get; set; }
        public string ServiceName { get; set; }
    }

    public class CompletedAppointment
    {
        public DateTime CompletedDate { get; set; }
        public string CustomerName { get; set; }
        public string ServiceName { get; set; }
    }

    public class PendingAppointment
    {
        public DateTime AppointmentDate { get; set; }
        public string CustomerName { get; set; }
        public string ServiceName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Vet
{
    public class VetDashboardData
    {
        public List<NewestAppointment> NewestCompletedAppointment { get; set; }
        public List<NextAppointment> NextUpcomingAppointment { get; set; }
    }
}

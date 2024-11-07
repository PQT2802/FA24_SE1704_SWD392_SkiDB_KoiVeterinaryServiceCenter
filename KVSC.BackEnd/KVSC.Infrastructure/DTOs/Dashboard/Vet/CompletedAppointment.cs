using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Vet
{
    public class CompletedAppointment
    {
        public Guid AppointmentId { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string CustomerName { get; set; }
        public string ServiceName { get; set; }
    }
}

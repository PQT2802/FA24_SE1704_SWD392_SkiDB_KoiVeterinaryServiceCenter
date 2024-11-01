using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Vet
{
    public class NewestAppointment
    {
        public DateTime? CompletedDate { get; set; }
        public Guid AppointmentId { get; set; }
        public string CustomerName { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.AssignVeterinarian
{
    public class AssignVeterinarianRequest
    {
        public Guid AppointmentId { get; set; }
        public Guid VeterinarianId { get; set; }
    }

}

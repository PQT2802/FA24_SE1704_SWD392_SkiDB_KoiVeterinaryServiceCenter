using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.GetAppointment
{
    public class GetAllAppointment
    {
        public Guid AppointmentListId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid PetServiceId { get; set; }
        public Guid VeterinarianId { get; set; }
        public string CustomerName { get; set; }
        public string VeterinarianName { get; set; }
        public string ServiceName { get; set; }
        public string ServiceCategory { get; set; }
        public string Status { get; set; }
        public bool IsOnline {  get; set; }
        public DateTime AppointmentDate { get; set; }
        public Guid UserIdOfVeterinarian { get; set; }
    }
}

using KVSC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.GetAppointment
{
    public class GetAppointmentWithAvailableVeterinarians
    {
        public GetAllAppointment Appointment { get; set; }
        public List<VeterinarianSchedule> AvailableVeterinarians { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.MakeAppointment
{
    public class MakeAppointmentResponse
    {
        public Extensions<MakeAppointmentResponseData> Extensions { get; set; }
    }
    public class MakeAppointmentResponseData
    {
        public Guid Id { get; set; }
    }
}

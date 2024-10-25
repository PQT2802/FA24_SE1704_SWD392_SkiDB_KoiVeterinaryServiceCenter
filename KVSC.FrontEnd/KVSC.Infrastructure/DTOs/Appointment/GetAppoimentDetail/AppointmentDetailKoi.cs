using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail
{
    public class AppointmentDetailKoi
    {
        public string Name { get; set; }

        public int? Age { get; set; }

        public int Quantity { get; set; }

        public string? Color { get; set; }

        public double? Length { get; set; }

        public double? Weight { get; set; }
    }
}

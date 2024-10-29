using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail
{
    public class AppointmentDetailService
    {
        public string ServiceName { get; set; }

        public string ServiceCategory { get; set; }

        public string PetDescription { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime AppointmentDate { get; set; }

        public decimal Cost { get; set; }

        public string Duration { get; set; }
    }
}

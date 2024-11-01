using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Manager
{
    public class AppointmentDetail
    {
        public Guid AppointmentId { get; set; } 
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } 

        public string CustomerName { get; set; }
        public string PetName { get; set; } 

        public string ServiceName { get; set; } 
        public string VeterinarianName { get; set; }
    }
}

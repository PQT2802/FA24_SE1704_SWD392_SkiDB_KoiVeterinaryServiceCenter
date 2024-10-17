using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KVSC.Infrastructure.DTOs.Appointment
{
    public class AppointmentList 
    {
        public Extensions<List<AppointmentListData>> Extensions { get; set; }
        
    }
    public class AppointmentListData : IPropertyNameProvider
    {
        public Guid AppointmentListId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid PetServiceId { get; set; }
        public Guid VeterinarianId { get; set; }
        public string CustomerName { get; set; }
        public string VeterinarianName { get; set; }
        public string ServiceName { get; set; }
        public string Status { get; set; }
        public DateTime AppointmentDate { get; set; }

        public List<string> GetPropertyNames()
        {
            return new List<string> { nameof(CustomerName), nameof(VeterinarianName), nameof(ServiceName), nameof(Status), nameof(AppointmentDate) };
        }
    }
}

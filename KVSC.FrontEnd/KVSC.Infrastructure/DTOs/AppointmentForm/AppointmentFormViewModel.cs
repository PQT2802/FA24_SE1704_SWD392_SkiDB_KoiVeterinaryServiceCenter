using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.ServiceDetail;

namespace KVSC.Infrastructure.DTOs
{
    public class AppointmentFormViewModel
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; }  // User's name
        public string CustomerEmail { get; set; }  // User's email
        public string CustomerPhone { get; set; }  // User's phone number
        public List<PetData> Pets { get; set; } = new List<PetData>();
        public List<Data> Services { get; set; }
        public DateTime AppointmentDate { get; set; }
    }




}
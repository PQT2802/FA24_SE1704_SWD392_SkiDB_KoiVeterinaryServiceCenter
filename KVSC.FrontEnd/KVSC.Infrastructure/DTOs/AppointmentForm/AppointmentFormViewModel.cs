using KVSC.Infrastructure.DTOs.Service.ServiceDetail;

namespace KVSC.Infrastructure.DTOs
{
    public class AppointmentFormViewModel
    {
        public Guid CustomerId { get; set; }
        public Guid PetServiceId { get; set; }
        public DateTime AppointmentDate { get; set; }

        public List<PetServiceDto> Services { get; set; } = new List<PetServiceDto>();
    }

}
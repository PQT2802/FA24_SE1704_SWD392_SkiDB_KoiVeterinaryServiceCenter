using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.User;
using KoiServicesData = KVSC.Infrastructure.DTOs.Service.KoiServicesData;

namespace KVSC.Infrastructure.DTOs
{
    public class AppointmentFormViewModel
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public List<PetData> Pets { get; set; }
        public List<KoiServicesData> Services { get; set; }
        public List<VeterinarianInfo> Veterinarians { get; set; }
        public DateTime AppointmentDate { get; set; }

        // Nullable properties for selected values in the form
        public Guid? SelectedPetId { get; set; }
        public Guid? SelectedServiceId { get; set; }
        public Guid? SelectedVeterinarianId { get; set; }

        // Add this property for error messages
        public List<ErrorDetail> ErrorMessage { get; set; } = new List<ErrorDetail>(); // Ensure it's initialized
    }
}
namespace KVSC.Infrastructure.DTOs;

public class MakeAppointmentForServiceRequest
{
    public Guid CustomerId { get; set; }
    public Guid PetServiceId { get; set; }
    public Guid? PetId { get; set; }
    public List<Guid>? VeterinarianIds { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Notes { get; set; }
}
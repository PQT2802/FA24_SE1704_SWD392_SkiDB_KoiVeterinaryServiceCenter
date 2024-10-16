namespace KVSC.Infrastructure.DTOs;

public class MakeAppointmentForServiceRequest
{
    public Guid CustomerId { get; set; }  // ID of the customer making the appointment
    public Guid PetServiceId { get; set; }  // ID of the pet service for which the appointment is being made
    public Guid? PetId { get; set; }  // Optional: ID of the pet associated with the appointment (if applicable)
    public DateTime AppointmentDate { get; set; }  // The date and time of the appointment

    public string Notes { get; set; }  // Optional: Any additional notes or requests for the appointment
}
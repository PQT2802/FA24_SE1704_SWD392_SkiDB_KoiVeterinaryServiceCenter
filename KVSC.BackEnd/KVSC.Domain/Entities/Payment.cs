namespace KVSC.Domain.Entities;

public class Payment : BaseEntity
{
    public Guid AppointmentId { get; set; } // Foreign key to Order
    public Appointment Appointment { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal Deposit { get; set; }
    public bool Status { get; set; }
}
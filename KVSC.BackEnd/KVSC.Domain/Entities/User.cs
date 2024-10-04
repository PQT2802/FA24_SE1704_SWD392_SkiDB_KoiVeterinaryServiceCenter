namespace KVSC.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public DateTime? DateOfBirth { get; set; }

        // Relationships
        public virtual ICollection<Pet>? Pets { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

        // One-to-one relationship with Cart
        public virtual Cart? Cart { get; set; }
    }



}

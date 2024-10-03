namespace KVSC.Domain.Entities
{
    public class Pet : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string ImageUrl { get; set; }
        public string Color { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public DateTime LastHealthCheck { get; set; }
        public int HealthStatus { get; set; }

        // Foreign key relationship
        public Guid OwnerId { get; set; }
        public User Owner { get; set; } // Reference to the User
    }
}

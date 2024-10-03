namespace KVSC.Domain.Entities;

public class PetServiceCategory : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ServiceType { get; set; }
    public string ApplicableTo { get; set; }

    // Relationships
    public virtual ICollection<PetService> PetServices { get; set; }
}
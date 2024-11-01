namespace KVSC.Domain.Entities;

public class PetServiceCategory : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string ServiceType { get; set; } //sử dụng để phân loại các loại dịch vụ vd: Consultation, Treatment, Health Check, Nutrition Plan
    public string ApplicableTo { get; set; } //có thể mô tả đối tượng dịch vụ phù hợp vd: All Koi Varieties

    public bool IsOnline { get; set; }
    // Relationships
    public ICollection<PetService> PetServices { get; set; }
}
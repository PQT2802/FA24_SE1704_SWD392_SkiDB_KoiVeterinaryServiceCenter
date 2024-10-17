namespace KVSC.Infrastructure.DTOs.Service.ServiceDetail;

public class PetServiceDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } // This corresponds to "name" in the JSON
    public Guid PetServiceCategoryId { get; set; } // Corresponds to "petServiceCategoryId"
    public string Description { get; set; }
    public decimal BasePrice { get; set; } // Corresponds to "basePrice"
    public string Duration { get; set; } // Corresponds to "duration"
    public string ImageUrl { get; set; } // Corresponds to "imageUrl"
    public DateTime AvailableFrom { get; set; } // Corresponds to "availableFrom"
    public DateTime AvailableTo { get; set; } // Corresponds to "availableTo"
    public decimal TravelCost { get; set; } // Corresponds to "travelCost"
    public DateTime CreatedDate { get; set; } // Corresponds to "createdDate"
    public bool IsDeleted { get; set; } // Corresponds to "isDeleted"
}

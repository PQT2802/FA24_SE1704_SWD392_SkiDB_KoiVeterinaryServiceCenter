﻿namespace KVSC.Domain.Entities;

public class PetService : BaseEntity
{
    public Guid PetServiceCategoryId { get; set; } // Foreign key to ServiceCategory
    public decimal BasePrice { get; set; }
    public string Duration { get; set; }
    public string ImageUrl { get; set; }
    public int StaffQuantity { get; set; }
    public DateTime AvailableFrom { get; set; }
    public DateTime AvailableTo { get; set; }
    public decimal TravelCost { get; set; }

    // Relationships
    public ICollection<OrderItem> OrderItems { get; set; }
}
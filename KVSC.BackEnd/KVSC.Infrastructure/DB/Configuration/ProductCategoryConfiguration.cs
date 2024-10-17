using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            // Seed sample data
            builder.HasData(
                new ProductCategory
                {
                    Id = new Guid("11111111-1111-1111-1111-111111111111"), // Matches the category for "Medicines"
                    Name = "Medicines",
                    Description = "Medicines for Koi fish treatments."
                },
                new ProductCategory
                {
                    Id = new Guid("22222222-2222-2222-2222-222222222222"), // Matches the category for "Water Treatment"
                    Name = "Water Treatment",
                    Description = "Products for water conditioning and treatment."
                },
                new ProductCategory
                {
                    Id = new Guid("33333333-3333-3333-3333-333333333333"), // Matches the category for "Pond Equipment"
                    Name = "Pond Equipment",
                    Description = "Equipment and accessories for Koi ponds."
                },
                new ProductCategory
                {
                    Id = new Guid("44444444-4444-4444-4444-444444444444"), // Matches the category for "Food & Nutrition"
                    Name = "Food & Nutrition",
                    Description = "Food and nutritional supplements for Koi fish."
                },
                new ProductCategory
                {
                    Id = new Guid("55555555-5555-5555-5555-555555555555"), // Matches the category for "Health Monitoring"
                    Name = "Health Monitoring",
                    Description = "Devices and kits for monitoring Koi health."
                },
                new ProductCategory
                {
                    Id = new Guid("66666666-6666-6666-6666-666666666666"), // Matches the category for "Cleaning & Maintenance"
                    Name = "Cleaning & Maintenance",
                    Description = "Products for cleaning and maintaining Koi ponds."
                },
                new ProductCategory
                {
                    Id = new Guid("77777777-7777-7777-7777-777777777777"), // Matches the category for "Breeding Supplies"
                    Name = "Breeding Supplies",
                    Description = "Supplies for Koi breeding and spawning."
                },
                new ProductCategory
                {
                    Id = new Guid("88888888-8888-8888-8888-888888888888"), // Matches the category for "Pond Landscaping"
                    Name = "Pond Landscaping",
                    Description = "Materials and accessories for pond landscaping."
                },
                new ProductCategory
                {
                    Id = new Guid("99999999-9999-9999-9999-999999999999"), // Matches the category for "Fish Transportation"
                    Name = "Fish Transportation",
                    Description = "Tools and equipment for safe fish transportation."
                },
                new ProductCategory
                {
                    Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), // Matches the category for "Emergency Supplies"
                    Name = "Emergency Supplies",
                    Description = "Essential supplies for emergency situations with Koi fish."
                }
            );
        }
    }
}

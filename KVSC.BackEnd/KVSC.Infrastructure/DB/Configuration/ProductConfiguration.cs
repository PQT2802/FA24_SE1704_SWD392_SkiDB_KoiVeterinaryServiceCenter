using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = new Guid("11111111-1111-1111-1111-111111111111"),
                    ProductCategoryId = new Guid("11111111-1111-1111-1111-111111111111"),  // Matches the "Medicines" category
                    Name = "Anti-Parasite Medication",
                    Description = "Medicine to treat parasite infections in Koi.",
                    Price = 50.00m,
                    StockQuantity = 100,
                    ImageUrl = "https://example.com/image1.jpg"
                },
                new Product
                {
                    Id = new Guid("22222222-2222-2222-2222-222222222222"),
                    ProductCategoryId = new Guid("22222222-2222-2222-2222-222222222222"),  // Matches the "Water Treatment" category
                    Name = "Water Conditioner",
                    Description = "Water conditioner for Koi ponds.",
                    Price = 25.00m,
                    StockQuantity = 200,
                    ImageUrl = "https://example.com/image2.jpg"
                },
                new Product
                {
                    Id = new Guid("33333333-3333-3333-3333-333333333333"),
                    ProductCategoryId = new Guid("11111111-1111-1111-1111-111111111111"),  // Matches the "Medicines" category
                    Name = "Koi Growth Supplement",
                    Description = "Nutritional supplement to enhance Koi growth.",
                    Price = 35.00m,
                    StockQuantity = 150,
                    ImageUrl = "https://example.com/image3.jpg"
                },
                new Product
                {
                    Id = new Guid("44444444-4444-4444-4444-444444444444"),
                    ProductCategoryId = new Guid("22222222-2222-2222-2222-222222222222"),  // Matches the "Water Treatment" category
                    Name = "Pond pH Stabilizer",
                    Description = "Stabilizes the pH level of pond water.",
                    Price = 40.00m,
                    StockQuantity = 80,
                    ImageUrl = "https://example.com/image4.jpg"
                },
                new Product
                {
                    Id = new Guid("55555555-5555-5555-5555-555555555555"),
                    ProductCategoryId = new Guid("11111111-1111-1111-1111-111111111111"),  // Matches the "Medicines" category
                    Name = "Fungal Treatment for Koi",
                    Description = "Treatment for fungal infections in Koi.",
                    Price = 60.00m,
                    StockQuantity = 120,
                    ImageUrl = "https://example.com/image5.jpg"
                },
                new Product
                {
                    Id = new Guid("66666666-6666-6666-6666-666666666666"),
                    ProductCategoryId = new Guid("22222222-2222-2222-2222-222222222222"),  // Matches the "Water Treatment" category
                    Name = "Koi Pond Filter",
                    Description = "Replacement filter for Koi ponds.",
                    Price = 75.00m,
                    StockQuantity = 60,
                    ImageUrl = "https://example.com/image6.jpg"
                },
                new Product
                {
                    Id = new Guid("77777777-7777-7777-7777-777777777777"),
                    ProductCategoryId = new Guid("11111111-1111-1111-1111-111111111111"),  // Matches the "Medicines" category
                    Name = "Koi Antibiotic",
                    Description = "Antibiotic for treating bacterial infections in Koi.",
                    Price = 45.00m,
                    StockQuantity = 90,
                    ImageUrl = "https://example.com/image7.jpg"
                },
                new Product
                {
                    Id = new Guid("88888888-8888-8888-8888-888888888888"),
                    ProductCategoryId = new Guid("22222222-2222-2222-2222-222222222222"),  // Matches the "Water Treatment" category
                    Name = "Algae Control Solution",
                    Description = "Prevents algae buildup in Koi ponds.",
                    Price = 30.00m,
                    StockQuantity = 170,
                    ImageUrl = "https://example.com/image8.jpg"
                },
                new Product
                {
                    Id = new Guid("99999999-9999-9999-9999-999999999999"),
                    ProductCategoryId = new Guid("11111111-1111-1111-1111-111111111111"),  // Matches the "Medicines" category
                    Name = "Parasite Control Solution",
                    Description = "Controls parasite infections in Koi.",
                    Price = 55.00m,
                    StockQuantity = 100,
                    ImageUrl = "https://example.com/image9.jpg"
                },
                new Product
                {
                    Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    ProductCategoryId = new Guid("22222222-2222-2222-2222-222222222222"),  // Matches the "Water Treatment" category
                    Name = "Oxygen Booster for Ponds",
                    Description = "Increases oxygen levels in Koi ponds.",
                    Price = 65.00m,
                    StockQuantity = 130,
                    ImageUrl = "https://example.com/image10.jpg"
                }
            );
        }
    }
}

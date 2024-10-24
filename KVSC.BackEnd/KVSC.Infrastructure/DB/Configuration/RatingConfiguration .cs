using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData
            (
                new Rating
                {
                    Id = Guid.Parse("1b2c3d4e-5f6a-7b8c-9d10-11e12f13a14b"),
                    ServiceId = Guid.Parse("f6a59f70-c0db-45b4-a598-045a005d42ed"), // Emergency Care
                    CustomerId = Guid.Parse("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Customer_1
                    Score = 5,
                    Feedback = "Excellent service!",
                    CreatedDate = DateTime.UtcNow
                },
                new Rating
                {
                    Id = Guid.Parse("2e3f4a5b-6c7d-8e9f-0a1b-21c22d23e24f"),
                    ServiceId = Guid.Parse("7d80bd0a-7780-4c4c-981b-48d7f8784405"), // Parasite Treatment
                    CustomerId = Guid.Parse("bca84e29-de4d-475b-a3ad-a02e937efa14"), // Customer_2
                    Score = 4,
                    Feedback = "Good service but could be faster.",
                    CreatedDate = DateTime.UtcNow
                },
                new Rating
                {
                    Id = Guid.NewGuid(),
                    ServiceId = Guid.Parse("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"), // Water Quality Testing
                    CustomerId = Guid.Parse("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Customer_3
                    Score = 3,
                    Feedback = "Average experience.",
                    CreatedDate = DateTime.UtcNow
                },
                new Rating
                {
                    Id = Guid.NewGuid(),
                    ServiceId = Guid.Parse("39ebc58b-6731-491d-949d-82f387dce82e"), // Koi Feeding Service
                    CustomerId = Guid.Parse("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Customer_4
                    Score = 2,
                    Feedback = "Not satisfied with the waiting time.",
                    CreatedDate = DateTime.UtcNow
                },
                new Rating
                {
                    Id = Guid.NewGuid(),
                    ServiceId = Guid.Parse("33e71556-d924-4101-bd1f-8707ca0e6f87"), // Koi Feeding Service (Duplicate service example)
                    CustomerId = Guid.Parse("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Customer_5
                    Score = 5,
                    Feedback = "Very professional and caring staff.",
                    CreatedDate = DateTime.UtcNow
                }
            );
        }
    }
}

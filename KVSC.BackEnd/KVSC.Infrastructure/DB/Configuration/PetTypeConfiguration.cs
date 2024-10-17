using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class PetTypeConfiguration : IEntityTypeConfiguration<PetType>
    {
        public void Configure(EntityTypeBuilder<PetType> builder)
        {
            // Seed sample data for PetType
            builder.HasData(
                new PetType
                {
                    Id = new Guid("e1111111-1111-1111-1111-111111111111"),
                    GeneralType = "Fish",
                    SpecificType = "Koi Fish",
                    PetHabitatId = new Guid("11111111-1111-1111-1111-111111111111"),
                },
                new PetType
                {
                    Id = new Guid("e2222222-2222-2222-2222-222222222222"),
                    GeneralType = "Fish",
                    SpecificType = "Goldfish",
                    PetHabitatId = new Guid("11111111-1111-1111-1111-111111111111"),
                },
                new PetType
                {
                    Id = new Guid("e3333333-3333-3333-3333-333333333333"),
                    GeneralType = "Reptile",
                    SpecificType = "Turtle",
                    PetHabitatId = new Guid("11111111-1111-1111-1111-111111111111"),
                },
                new PetType
                {
                    Id = new Guid("e4444444-4444-4444-4444-444444444444"),
                    GeneralType = "Mammal",
                    SpecificType = "Dog",
                    PetHabitatId = new Guid("11111111-1111-1111-1111-111111111111"),
                },
                new PetType
                {
                    Id = new Guid("e5555555-5555-5555-5555-555555555555"),
                    GeneralType = "Mammal",
                    SpecificType = "Cat",
                    PetHabitatId = new Guid("11111111-1111-1111-1111-111111111111"),
                },
                new PetType
                {
                    Id = new Guid("e6666666-6666-6666-6666-666666666666"),
                    GeneralType = "Bird",
                    SpecificType = "Parrot",
                    PetHabitatId = new Guid("11111111-1111-1111-1111-111111111111"),
                },
                new PetType
                {
                    Id = new Guid("e7777777-7777-7777-7777-777777777777"),
                    GeneralType = "Bird",
                    SpecificType = "Canary",
                    PetHabitatId = new Guid("11111111-1111-1111-1111-111111111111"),
                },
                new PetType
                {
                    Id = new Guid("e8888888-8888-8888-8888-888888888888"),
                    GeneralType = "Fish",
                    SpecificType = "Betta Fish",
                    PetHabitatId = new Guid("11111111-1111-1111-1111-111111111111"),
                },
                new PetType
                {
                    Id = new Guid("e9999999-9999-9999-9999-999999999999"),
                    GeneralType = "Reptile",
                    SpecificType = "Iguana",
                    PetHabitatId = new Guid("11111111-1111-1111-1111-111111111111"),
                },
                new PetType
                {
                    Id = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    GeneralType = "Mammal",
                    SpecificType = "Hamster",
                    PetHabitatId = new Guid("11111111-1111-1111-1111-111111111111"),
                }
            );
        }
    }
}

using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class PetHabitatConfiguration : IEntityTypeConfiguration<PetHabitat>
{
    public void Configure(EntityTypeBuilder<PetHabitat> builder)
    {
        builder.HasData(
            new PetHabitat
            {
                Id = new Guid("11111111-1111-1111-1111-111111111111"), // Valid PetHabitat Id
                HabitatType = "Freshwater Pond",
            },
            new PetHabitat
            {
                Id = new Guid("22222222-2222-2222-2222-222222222222"), // Valid PetHabitat Id
                HabitatType = "Saltwater Pond",
            }
        );
    }
}

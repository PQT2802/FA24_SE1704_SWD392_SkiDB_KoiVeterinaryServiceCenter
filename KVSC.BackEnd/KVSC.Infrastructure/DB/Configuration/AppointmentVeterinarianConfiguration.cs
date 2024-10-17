using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class AppointmentVeterinarianConfiguration : IEntityTypeConfiguration<AppointmentVeterinarian>
    {
        public void Configure(EntityTypeBuilder<AppointmentVeterinarian> builder)
        {
            // Seed sample data for AppointmentVeterinarian relationship
            builder.HasData(
                new AppointmentVeterinarian
                {
                    Id = new Guid("11111111-aaaa-1111-aaaa-111111111111"),
                    AppointmentId = new Guid("11111111-1111-1111-1111-111111111111"), // Link with Appointment (Pending)
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") // Link with Veterinarian 1
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                    AppointmentId = new Guid("22222222-2222-2222-2222-222222222222"), // Link with Appointment (Waiting)
                    VeterinarianId = new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") // Link with Veterinarian 2
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                    AppointmentId = new Guid("33333333-3333-3333-3333-333333333333"), // Link with Appointment (Pending)
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") // Link with Veterinarian 1
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("44444444-aaaa-4444-aaaa-444444444444"),
                    AppointmentId = new Guid("44444444-4444-4444-4444-444444444444"), // Link with Appointment (Waiting)
                    VeterinarianId = new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") // Link with Veterinarian 2
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("55555555-aaaa-5555-aaaa-555555555555"),
                    AppointmentId = new Guid("55555555-5555-5555-5555-555555555555"), // Link with Appointment (Waiting)
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") // Link with Veterinarian 1
                }
            );
        }
    }
}

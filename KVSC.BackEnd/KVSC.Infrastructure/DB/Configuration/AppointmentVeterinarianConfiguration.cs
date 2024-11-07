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
                    AppointmentId = new Guid("11111111-1111-1111-1111-111111111111"), // Link with Appointment (waiting)
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") // Link with Veterinarian 1 and customer 1
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("22222222-aaaa-2222-aaaa-222222222222"),
                    AppointmentId = new Guid("22222222-2222-2222-2222-222222222222"), // Link with Appointment (Reported)
                    VeterinarianId = new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") // Link with Veterinarian 2 and customer 1
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("33333333-aaaa-3333-aaaa-333333333333"),
                    AppointmentId = new Guid("33333333-3333-3333-3333-333333333333"), // Link with Appointment (Waiting)
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") // Link with Veterinarian 1 and customer 3
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("55555555-bbbb-5555-bbbb-555555555555"),
                    AppointmentId = new Guid("99999999-9999-9999-9999-999999999999"), // Link with Appointment (Reported)
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") // Link with Veterinarian 1 vs customer 3
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("55555555-cccc-5555-cccc-555555555555"),
                    AppointmentId = new Guid("88888888-8888-8888-8888-888888888888"), // Link with Appointment (reported)
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") // Link with Veterinarian 1 vs customer 1
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("55555555-dddd-5555-cccc-555555555555"),
                    AppointmentId = new Guid("66666666-6666-6666-6666-666666666666"), // Link with Appointment (InProgress)
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") // Link with Veterinarian 1
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("55555555-ddcc-5555-cccc-555555555555"),
                    AppointmentId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), // Link with Appointment (Completed)
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") // Link with Veterinarian 1 vs customer 2
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("55555555-bbbb-5555-cccc-555555555555"),
                    AppointmentId = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), // Link with Appointment (Completed)
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4") // Link with Veterinarian 1
                },
                new AppointmentVeterinarian
                {
                    Id = new Guid("55555555-bbbb-5555-dddd-555555555555"),
                    AppointmentId = new Guid("bbbbbcbb-bbbb-bcbb-bbbb-bbcbbbbbbbbb"), // Link with Appointment (Completed)
                    VeterinarianId = new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b") // Link with Veterinarian 2 vs customer 1
                }
            );
        }
    }
}

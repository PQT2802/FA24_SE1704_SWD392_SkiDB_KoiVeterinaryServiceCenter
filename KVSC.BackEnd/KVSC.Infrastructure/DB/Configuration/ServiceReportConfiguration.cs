using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class ServiceReportConfiguration : IEntityTypeConfiguration<ServiceReport>
    {
        public void Configure(EntityTypeBuilder<ServiceReport> builder)
        {
            // Seed sample data
            builder.HasData(
                new ServiceReport
                {
                    Id = new Guid("44444444-4444-4444-4444-444444444444"),
                    AppointmentId = new Guid("44444444-4444-4444-4444-444444444444"),
                    ReportContent = "Fungal infection treatment recommended.",
                    ReportDate = new DateTime(2024, 11, 4),
                    Recommendations = "Apply antifungal medication.",
                    HasPrescription = true,
                    PrescriptionId = new Guid("22222222-2222-2222-2222-222222222222"),
                    IsCompleted = true
                },
                new ServiceReport
                {
                    Id = new Guid("11111111-1111-1111-1111-111111111111"),
                    AppointmentId = new Guid("11111111-1111-1111-1111-111111111111"),
                    ReportContent = "Report for Koi health check, everything looks fine.",
                    ReportDate = new DateTime(2024, 11, 1),
                    Recommendations = "Regular water testing recommended.",
                    HasPrescription = false,
                    IsCompleted = true
                },
                new ServiceReport
                {
                    Id = new Guid("22222222-2222-2222-2222-222222222222"),
                    AppointmentId = new Guid("22222222-2222-2222-2222-222222222222"),
                    ReportContent = "Parasite treatment required for Koi.",
                    ReportDate = new DateTime(2024, 11, 2),
                    Recommendations = "Follow the prescribed medicine.",
                    HasPrescription = true,
                    PrescriptionId = new Guid("11111111-1111-1111-1111-111111111111"),
                    IsCompleted = true
                },
                new ServiceReport
                {
                    Id = new Guid("33333333-3333-3333-3333-333333333333"),
                    AppointmentId = new Guid("33333333-3333-3333-3333-333333333333"),
                    ReportContent = "Water quality test completed, minor adjustments needed.",
                    ReportDate = new DateTime(2024, 11, 3),
                    Recommendations = "Adjust pH levels in the water.",
                    HasPrescription = false,
                    IsCompleted = true
                },
                new ServiceReport
                {
                    Id = new Guid("55555555-5555-5555-5555-555555555555"),
                    AppointmentId = new Guid("55555555-5555-5555-5555-555555555555"),
                    ReportContent = "Emergency care completed, fish stable.",
                    ReportDate = new DateTime(2024, 11, 5),
                    Recommendations = "Monitor fish for 48 hours.",
                    HasPrescription = false,
                    IsCompleted = true
                },
                new ServiceReport
                {
                    Id = new Guid("66666666-6666-6666-6666-666666666666"),
                    AppointmentId = new Guid("66666666-6666-6666-6666-666666666666"),
                    ReportContent = "Feeding routine assessment, nutrition levels adequate.",
                    ReportDate = new DateTime(2024, 11, 6),
                    Recommendations = "Maintain current diet, no changes needed.",
                    HasPrescription = false,
                    IsCompleted = true
                },
                new ServiceReport
                {
                    Id = new Guid("77777777-7777-7777-7777-777777777777"),
                    AppointmentId = new Guid("77777777-7777-7777-7777-777777777777"),
                    ReportContent = "Transportation completed successfully.",
                    ReportDate = new DateTime(2024, 11, 7),
                    Recommendations = "Fish arrived safely. No action needed.",
                    HasPrescription = false,
                    IsCompleted = true
                },
                new ServiceReport
                {
                    Id = new Guid("88888888-8888-8888-8888-888888888888"),
                    AppointmentId = new Guid("88888888-8888-8888-8888-888888888888"),
                    ReportContent = "Koi breeding assistance provided. Successful pairing observed.",
                    ReportDate = new DateTime(2024, 11, 8),
                    Recommendations = "Monitor breeding progress over the next 10 days.",
                    HasPrescription = false,
                    IsCompleted = true
                },
                new ServiceReport
                {
                    Id = new Guid("99999999-9999-9999-9999-999999999999"),
                    AppointmentId = new Guid("99999999-9999-9999-9999-999999999999"),
                    ReportContent = "Water quality testing performed. Filter replacement needed.",
                    ReportDate = new DateTime(2024, 11, 9),
                    Recommendations = "Replace filter immediately to prevent water contamination.",
                    HasPrescription = false,
                    IsCompleted = true
                },
                new ServiceReport
                {
                    Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    AppointmentId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    ReportContent = "Health check performed. Minor injuries found.",
                    ReportDate = new DateTime(2024, 11, 10),
                    Recommendations = "Apply antiseptic and monitor healing progress.",
                    HasPrescription = true,
                    PrescriptionId = new Guid("33333333-3333-3333-3333-333333333333"),
                    IsCompleted = true
                }
            );
        }
    }
}

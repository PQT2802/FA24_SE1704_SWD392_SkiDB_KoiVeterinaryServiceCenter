using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            // Seed sample data for Prescription, aligned with ServiceReport
            builder.HasData(
                 new Prescription
                 {
                     Id = new Guid("11111111-1111-1111-1111-111111111111"),
                     PrescriptionDate = new DateTime(2024, 11, 2),
                     ServiceReportId = new Guid("22222222-2222-2222-2222-222222222222")
                 },
                 new Prescription
                 {
                     Id = new Guid("22222222-2222-2222-2222-222222222222"),
                     PrescriptionDate = new DateTime(2024, 11, 4),
                     ServiceReportId = new Guid("44444444-4444-4444-4444-444444444444")
                 },
                 new Prescription
                 {
                     Id = new Guid("33333333-3333-3333-3333-333333333333"),
                     PrescriptionDate = new DateTime(2024, 11, 10),
                     ServiceReportId = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa")
                 }
             );
        }
    }
}

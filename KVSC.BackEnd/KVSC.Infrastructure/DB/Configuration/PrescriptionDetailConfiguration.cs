using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class PrescriptionDetailConfiguration : IEntityTypeConfiguration<PrescriptionDetail>
    {
        public void Configure(EntityTypeBuilder<PrescriptionDetail> builder)
        {
            // Seed sample data for PrescriptionDetails, matching only the three Prescription entries
            builder.HasData(
               new PrescriptionDetail
               {
                   PrescriptionDetailId = new Guid("11111111-1111-1111-1111-111111111111"), // Valid GUID
                   PrescriptionId = new Guid("11111111-1111-1111-1111-111111111111"), // Match with Prescription 11111111
                   MedicineId = new Guid("11111111-1111-1111-1111-111111111111"),  // Match with Product 11111111
                   Quantity = 2,
                   Price = 100.00m
               },
               new PrescriptionDetail
               {
                   PrescriptionDetailId = new Guid("22222222-2222-2222-2222-222222222222"), // Valid GUID
                   PrescriptionId = new Guid("22222222-2222-2222-2222-222222222222"), // Match with Prescription 22222222
                   MedicineId = new Guid("22222222-2222-2222-2222-222222222222"),  // Match with Product 22222222
                   Quantity = 3,
                   Price = 150.00m
               },
               new PrescriptionDetail
               {
                   PrescriptionDetailId = new Guid("33333333-3333-3333-3333-333333333333"), // Valid GUID
                   PrescriptionId = new Guid("33333333-3333-3333-3333-333333333333"), // Match with Prescription 33333333
                   MedicineId = new Guid("33333333-3333-3333-3333-333333333333"),  // Match with Product 33333333
                   Quantity = 1,
                   Price = 50.00m
               },
               // Adding more PrescriptionDetails
               new PrescriptionDetail
               {
                   PrescriptionDetailId = new Guid("44444444-4444-4444-4444-444444444444"), // New entry
                   PrescriptionId = new Guid("22222222-2222-2222-2222-222222222222"), // Match with Prescription 22222222
                   MedicineId = new Guid("44444444-4444-4444-4444-444444444444"),  // New Medicine entry
                   Quantity = 4,
                   Price = 200.00m
               },
               new PrescriptionDetail
               {
                   PrescriptionDetailId = new Guid("55555555-5555-5555-5555-555555555555"), // New entry
                   PrescriptionId = new Guid("33333333-3333-3333-3333-333333333333"), // Match with Prescription 33333333
                   MedicineId = new Guid("55555555-5555-5555-5555-555555555555"),  // New Medicine entry
                   Quantity = 5,
                   Price = 250.00m
               }
            );
        }
    }
}

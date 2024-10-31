using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class VeterinarianScheduleConfiguration : IEntityTypeConfiguration<VeterinarianSchedule>
    {
        public void Configure(EntityTypeBuilder<VeterinarianSchedule> builder)
        {
            // Find next upcoming Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday based on DateTime.Now
            DateTime now = DateTime.Now;
            DateTime nextMonday = now.AddDays(((int)DayOfWeek.Monday - (int)now.DayOfWeek + 7) % 7);
            DateTime nextTuesday = now.AddDays(((int)DayOfWeek.Tuesday - (int)now.DayOfWeek + 7) % 7);
            DateTime nextWednesday = now.AddDays(((int)DayOfWeek.Wednesday - (int)now.DayOfWeek + 7) % 7);
            DateTime nextThursday = now.AddDays(((int)DayOfWeek.Thursday - (int)now.DayOfWeek + 7) % 7);
            DateTime nextFriday = now.AddDays(((int)DayOfWeek.Friday - (int)now.DayOfWeek + 7) % 7);
            DateTime nextSaturday = now.AddDays(((int)DayOfWeek.Saturday - (int)now.DayOfWeek + 7) % 7);
            DateTime nextSunday = now.AddDays(((int)DayOfWeek.Sunday - (int)now.DayOfWeek + 7) % 7);

            // Seed sample data
            builder.HasData(
                // Monday
                new VeterinarianSchedule
                {
                    Id = new Guid("9f6e0f34-45c2-46ea-8d65-8191d7c6fa6f"),
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                    Date = nextMonday,
                    StartTime = new TimeSpan(8, 0, 0),  // Morning
                    EndTime = new TimeSpan(12, 0, 0),    // Morning
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },
                // Tuesday
                new VeterinarianSchedule
                {
                    Id = new Guid("24ab377f-4312-495f-8f6f-738d347f70b3"),
                    VeterinarianId = new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                    Date = nextTuesday,
                    StartTime = new TimeSpan(13, 0, 0), // Afternoon
                    EndTime = new TimeSpan(17, 0, 0),   // Afternoon
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },
                // Wednesday
                new VeterinarianSchedule
                {
                    Id = new Guid("d0f377db-34e2-4b65-8f2f-76d347e70b41"),
                    VeterinarianId = new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                    Date = nextWednesday,
                    StartTime = new TimeSpan(8, 0, 0),  // Morning
                    EndTime = new TimeSpan(12, 0, 0),    // Morning
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },
                // Thursday
                new VeterinarianSchedule
                {
                    Id = new Guid("c034eaf7-d41b-46e1-bb5f-84843f4793c6"),
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                    Date = nextThursday,
                    StartTime = new TimeSpan(13, 0, 0), // Afternoon
                    EndTime = new TimeSpan(17, 0, 0),   // Afternoon
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },
                // Friday
                new VeterinarianSchedule
                {
                    Id = new Guid("eb0f377d-3412-4c62-8f6f-738d347f70b4"),
                    VeterinarianId = new Guid("d59b53f6-7bc4-4af7-b5f5-438e16b75dd4"),
                    Date = nextFriday,
                    StartTime = new TimeSpan(13, 0, 0), // Afternoon
                    EndTime = new TimeSpan(17, 0, 0),   // Afternoon
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },
                // Saturday
                new VeterinarianSchedule
                {
                    Id = new Guid("75856d7e-125c-4a36-9e24-fabc6d8a7e31"),
                    VeterinarianId = new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                    Date = nextSaturday,
                    StartTime = new TimeSpan(8, 0, 0),  // Morning
                    EndTime = new TimeSpan(12, 0, 0),    // Morning
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },
                // Sunday
                new VeterinarianSchedule
                {
                    Id = new Guid("6b34ed3f-0fb1-451e-90cc-bd53bc1ac3a9"),
                    VeterinarianId = new Guid("21a15a4f-32f5-4d45-a056-f0d61f384e1b"),
                    Date = nextSunday,
                    StartTime = new TimeSpan(17, 0, 0), // Evening
                    EndTime = new TimeSpan(21, 0, 0),   // Evening
                    IsAvailable = true,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                }
            );
        }
    }
}

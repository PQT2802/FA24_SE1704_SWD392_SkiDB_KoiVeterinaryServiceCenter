using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {

            // Seed sample data for appointments in each status (Pending, Waiting, InProgress, Reported, Completed)
            builder.HasData(
                // Pending Appointments
                new Appointment
                {
                    Id = new Guid("11111111-1111-1111-1111-111111111111"),
                    CustomerId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    PetId = new Guid("f1111111-1111-1111-1111-111111111111"),
                    PetServiceId = new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                    AppointmentDate = DateTime.UtcNow.AddDays(2), // Friday
                    Status = "Pending",
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Appointment
                {
                    Id = new Guid("22222222-2222-2222-2222-222222222222"),
                    CustomerId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    PetId = new Guid("f1111111-1111-1111-1111-111111111111"),
                    PetServiceId = new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                    AppointmentDate = DateTime.UtcNow.AddDays(-1), // Friday
                    Status = "Reported",
                    CreatedDate = DateTime.UtcNow.AddDays(-3),
                    IsDeleted = false
                },
                new Appointment
                {
                    Id = new Guid("33333333-3333-3333-3333-333333333333"),
                    CustomerId = new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                    PetId = new Guid("f3333333-3333-3333-3333-333333333333"),
                    PetServiceId = new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                    AppointmentDate = DateTime.UtcNow.AddDays(2), // Saturday
                    Status = "Pending",
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },

                // Waiting Appointments
                new Appointment
                {
                    Id = new Guid("44444444-4444-4444-4444-444444444444"),
                    CustomerId = new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                    PetServiceId = new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                    AppointmentDate = DateTime.UtcNow.AddDays(2), // Sunday
                    Status = "Pending",
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Appointment
                {
                    Id = new Guid("55555555-5555-5555-5555-555555555555"),
                    CustomerId = new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                    PetServiceId = new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                    AppointmentDate = DateTime.UtcNow.AddDays(3), // Tuesday
                    Status = "Pending",
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },

                // InProgress Appointments
                new Appointment
                {
                    Id = new Guid("66666666-6666-6666-6666-666666666666"),
                    CustomerId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),//cus1
                    PetServiceId = new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                    AppointmentDate =  DateTime.UtcNow, // now
                    Status = "InProgress",
                    CreatedDate = DateTime.UtcNow.AddDays(-2),
                    IsDeleted = false
                },
                new Appointment
                {
                    Id = new Guid("77777777-7777-7777-7777-777777777777"),
                    CustomerId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),//cus1
                    PetServiceId = new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                    AppointmentDate = DateTime.UtcNow.AddDays(3),// Tuesday
                    Status = "Pending",
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                },

                // Reported Appointments
                new Appointment
                {
                    Id = new Guid("88888888-8888-8888-8888-888888888888"),
                    CustomerId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    PetServiceId = new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                    AppointmentDate = DateTime.UtcNow.AddDays(-1), // Sunday
                    Status = "Reported",
                    CreatedDate = DateTime.UtcNow.AddDays(-3),
                    IsDeleted = false
                },
                new Appointment
                {
                    Id = new Guid("99999999-9999-9999-9999-999999999999"),
                    CustomerId = new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"),
                    PetServiceId = new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                    AppointmentDate = DateTime.UtcNow.AddDays(-2), // Tuesday
                    Status = "Reported",
                    CreatedDate = DateTime.UtcNow.AddDays(-5),
                    IsDeleted = false
                },

                // Completed Appointments
                new Appointment
                {
                    Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    CustomerId = new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"),
                    PetServiceId = new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                    AppointmentDate = DateTime.UtcNow.AddDays(-5), 
                    Status = "Completed",
                    CompletedDate = DateTime.UtcNow.AddDays(-3), // Completed on the same day
                    CreatedDate = DateTime.UtcNow.AddDays(-7),
                    IsDeleted = false
                },
                new Appointment
                {
                    Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                    CustomerId = new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                    PetServiceId = new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                    AppointmentDate = DateTime.UtcNow.AddDays(-3), 
                    Status = "Completed",
                    CompletedDate = DateTime.UtcNow, // Completed on the same day
                    CreatedDate = DateTime.UtcNow.AddDays(-5),
                    IsDeleted = false
                },
                new Appointment
                {
                    Id = new Guid("bbbbbcbb-bbbb-bcbb-bbbb-bbcbbbbbbbbb"),
                    CustomerId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    PetServiceId = new Guid("c33e3a87-0230-428b-8c06-ee91b7e8cc21"),
                    AppointmentDate = DateTime.UtcNow.AddDays(3), // Saturday
                    Status = "Pending",
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false
                }
            );
        }
    }
}

using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
                (
                //1
                new User
                {
                    Id = new Guid("4feb4940-94dc-4aed-b580-ee116b668704"), // Gán Id cố định
                    FullName = "Admin",
                    Email = "admin@gmail.com",
                    PhoneNumber = "123456789",
                    Address = "123 Main St",
                    Username = "Admin",
                    PasswordHash = "String123!",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    role = 1
                },
                //2
                new User
                {
                    Id = new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"), // Gán Id cố định
                    FullName = "Manager",
                    Email = "manager@gmail.com",
                    PhoneNumber = "123456789",
                    Address = "123 Main St",
                    Username = "Manager",
                    PasswordHash = "String123!",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    role = 2
                },
                //3
                new User
                {
                    Id = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"), // Gán Id cố định
                    FullName = "Veterinarian_1",
                    Email = "veterinarian1@gmail.com",
                    PhoneNumber = "123456789",
                    Address = "123 Main St",
                    Username = "Veterinarian_1",
                    PasswordHash = "String123!",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    role = 3
                },
                //4
                new User
                {
                    Id = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"), // Gán Id cố định
                    FullName = "Veterinarian_2",
                    Email = "veterinarian2@gmail.com",
                    PhoneNumber = "123456789",
                    Address = "123 Main St",
                    Username = "Veterinarian_2",
                    PasswordHash = "String123!",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    role = 3
                },
                //5
                new User
                {
                    Id = new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"), // Gán Id cố định
                    FullName = "Staff_1",
                    Email = "staff1@gmail.com",
                    PhoneNumber = "123456789",
                    Address = "123 Main St",
                    Username = "Staff_1",
                    PasswordHash = "String123!",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    role = 4
                },
                //6
                new User
                {
                    Id = new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"), // Gán Id cố định
                    FullName = "Staff_2",
                    Email = "staff2@gmail.com",
                    PhoneNumber = "123456789",
                    Address = "123 Main St",
                    Username = "Staff_2",
                    PasswordHash = "String123!",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    role = 4
                },
                //7
                new User
                {
                    Id = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"), // Gán Id cố định
                    FullName = "Customer_1",
                    Email = "customer1@gmail.com",
                    PhoneNumber = "123456789",
                    Address = "123 Main St",
                    Username = "Customer_1",
                    PasswordHash = "String123!",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    role = 5
                },
                new User
                {
                    Id = new Guid("bca84e29-de4d-475b-a3ad-a02e937efa14"), // Gán Id cố định
                    FullName = "Customer_2",
                    Email = "customer2@gmail.com",
                    PhoneNumber = "123456789",
                    Address = "123 Main St",
                    Username = "Customer_2",
                    PasswordHash = "String123!",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    role = 5
                },
                new User
                {
                    Id = new Guid("45a9dc1c-fb8a-4607-9a7e-d6b1359384d7"), // Gán Id cố định
                    FullName = "Customer_3",
                    Email = "customer3@gmail.com",
                    PhoneNumber = "123456789",
                    Address = "123 Main St",
                    Username = "Customer_3",
                    PasswordHash = "String123!",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    role = 5
                }

                );
        }
    }
}

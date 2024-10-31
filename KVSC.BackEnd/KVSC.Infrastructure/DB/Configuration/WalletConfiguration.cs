using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            // Define the table name
            builder.ToTable("Wallet");

            // Set up the primary key
            builder.HasKey(w => w.Id);

            // Configure properties
            builder.Property(w => w.Amount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            // Configure relationships
            builder.HasOne(w => w.User)
                .WithOne(u => u.Wallet)
                .HasForeignKey<Wallet>(w => w.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed wallet data for each user
            builder.HasData(
                new Wallet
                {
                    Id = Guid.NewGuid(),
                    UserId = new Guid("4feb4940-94dc-4aed-b580-ee116b668704"),
                    Amount = 1000.00m,
                    CreatedDate = DateTime.UtcNow
                },
                new Wallet
                {
                    Id = Guid.NewGuid(),
                    UserId = new Guid("b59d5d37-53d8-4cb6-98ed-520f49eafa73"),
                    Amount = 1000.00m,
                    CreatedDate = DateTime.UtcNow
                },
                new Wallet
                {
                    Id = Guid.NewGuid(),
                    UserId = new Guid("1dac24c4-08e2-4612-84dc-7c8960e483ea"),
                    Amount = 1000.00m,
                    CreatedDate = DateTime.UtcNow
                },
                new Wallet
                {
                    Id = Guid.NewGuid(),
                    UserId = new Guid("2430f703-cb67-4225-bb7e-c9abe5803b8a"),
                    Amount = 1000.00m,
                    CreatedDate = DateTime.UtcNow
                },
                new Wallet
                {
                    Id = Guid.NewGuid(),
                    UserId = new Guid("5f28fcb6-675b-4f97-a925-01ac8c68b5ac"),
                    Amount = 1000.00m,
                    CreatedDate = DateTime.UtcNow
                },
                // Add wallets for other users similarly
                new Wallet
                {
                    Id = Guid.NewGuid(),
                    UserId = new Guid("0d1fbbab-a175-4d90-8291-d5d96ebb9359"),
                    Amount = 1000.00m,
                    CreatedDate = DateTime.UtcNow
                },
                new Wallet
                {
                    Id = Guid.NewGuid(),
                    UserId = new Guid("dd0e9f37-d587-401d-932e-7f098eb60b3e"),
                    Amount = 1000.00m,
                    CreatedDate = DateTime.UtcNow
                }
                // Repeat for each user as needed
            );
        }
    }
}

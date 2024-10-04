using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KVSC.Infrastructure.DB
{
    public class KVSCContext : DbContext
    {
        public KVSCContext() { }
        public KVSCContext(DbContextOptions<KVSCContext> options)
            : base(options)
        {
        }

        #region DBSet
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PetService> PetServices { get; set; }
        public DbSet<PetServiceCategory> PetServiceCategories { get; set; }
        public DbSet<ComboService> ComboServices { get; set; }
        public DbSet<ComboServiceItem> ComboServiceItems { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define table names
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Pet>().ToTable("Pet");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Cart>().ToTable("Cart");
            modelBuilder.Entity<CartItem>().ToTable("CartItem");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
            modelBuilder.Entity<Payment>().ToTable("Payment");
            modelBuilder.Entity<PetService>().ToTable("PetService");
            modelBuilder.Entity<PetServiceCategory>().ToTable("PetServiceCategory");
            modelBuilder.Entity<ComboService>().ToTable("ComboService");
            modelBuilder.Entity<ComboServiceItem>().ToTable("ComboServiceItem");

            // Relationships and additional configuration

            // User has many Pets
            modelBuilder.Entity<User>()
                .HasMany(u => u.Pets)
                .WithOne(p => p.Owner)
                .HasForeignKey(p => p.OwnerId);

            // User has many Orders
            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);

            // User has many Carts
            modelBuilder.Entity<User>()
                .HasMany(u => u.Carts)
                .WithOne(c => c.Customer)
                .HasForeignKey(c => c.CustomerId);

            // Cart has many CartItems
            modelBuilder.Entity<Cart>()
                .HasMany(c => c.CartItems)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId);

            // Order has many OrderItems
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

            // OrderItem relationships (optional foreign keys)
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Pet)
                .WithMany()
                .HasForeignKey(oi => oi.PetId)
                .OnDelete(DeleteBehavior.Restrict); // Optional, can change based on your needs

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.PetService)
                .WithMany(s => s.OrderItems)
                .HasForeignKey(oi => oi.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Veterinarian)
                .WithMany()
                .HasForeignKey(oi => oi.VeterinarianId)
                .OnDelete(DeleteBehavior.Restrict);

            // PetService has many OrderItems
            modelBuilder.Entity<PetService>()
                .HasMany(ps => ps.OrderItems)
                .WithOne(oi => oi.PetService)
                .HasForeignKey(oi => oi.ServiceId);

            // Product has many OrderItems
            modelBuilder.Entity<Product>()
                .HasMany(p => p.OrderItems)
                .WithOne(oi => oi.Product)
                .HasForeignKey(oi => oi.ProductId);

            // PetServiceCategory has many PetServices
            modelBuilder.Entity<PetServiceCategory>()
                .HasMany(psc => psc.PetServices)
                .WithOne(ps => ps.PetServiceCategory)
                .HasForeignKey(ps => ps.PetServiceCategoryId);

            // ComboService -> ComboServiceItem (1-to-many)
            modelBuilder.Entity<ComboService>()
                .HasMany(c => c.ComboServiceItems)
                .WithOne(csi => csi.ComboService)
                .HasForeignKey(csi => csi.ComboServiceId);

            // PetService -> ComboServiceItem (1-to-many)
            modelBuilder.Entity<PetService>()
                .HasMany(ps => ps.ComboServiceItems)
                .WithOne(csi => csi.PetService)
                .HasForeignKey(csi => csi.PetServiceId);



            // Call base method
            base.OnModelCreating(modelBuilder);
        }
    }
}


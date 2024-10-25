using System;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB.Configuration;
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
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PetService> PetServices { get; set; }
        public DbSet<PetServiceCategory> PetServiceCategories { get; set; }
        public DbSet<ComboService> ComboServices { get; set; }
        public DbSet<ComboServiceItem> ComboServiceItems { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Veterinarian> Veterinarians { get; set; }
        public DbSet<VeterinarianSchedule> VeterinarianSchedules { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<PetHabitat> PetHabitats { get; set; }
        public DbSet<ServiceReport> ServiceReports { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
        public DbSet<AppointmentVeterinarian> AppointmentVeterinarians { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Role> Roles { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Entity Configurations

            // Apply entity configurations
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PetServiceCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PetServiceConfiguration());
            modelBuilder.ApplyConfiguration(new VeterinarianConfiguration());
            modelBuilder.ApplyConfiguration(new VeterinarianScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentVeterinarianConfiguration());
            modelBuilder.ApplyConfiguration(new PetConfiguration());
            modelBuilder.ApplyConfiguration(new PetTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceReportConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PetHabitatConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());

            #endregion

            #region Table Mappings
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Pet>().ToTable("Pet");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
            modelBuilder.Entity<Cart>().ToTable("Cart");
            modelBuilder.Entity<CartItem>().ToTable("CartItem");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
            modelBuilder.Entity<Payment>().ToTable("Payment");
            modelBuilder.Entity<PetService>().ToTable("PetService");
            modelBuilder.Entity<PetServiceCategory>().ToTable("PetServiceCategory");
            modelBuilder.Entity<ComboService>().ToTable("ComboService");
            modelBuilder.Entity<ComboServiceItem>().ToTable("ComboServiceItem");
            modelBuilder.Entity<Appointment>().ToTable("Appointment");
            modelBuilder.Entity<Veterinarian>().ToTable("Veterinarian");
            modelBuilder.Entity<VeterinarianSchedule>().ToTable("VeterinarianSchedule");
            modelBuilder.Entity<PetType>().ToTable("PetType");
            modelBuilder.Entity<Message>().ToTable("Message");
            modelBuilder.Entity<PetHabitat>().ToTable("PetHabitat");
            modelBuilder.Entity<ServiceReport>().ToTable("ServiceReport");
            modelBuilder.Entity<Prescription>().ToTable("Prescription");
            modelBuilder.Entity<PrescriptionDetail>().ToTable("PrescriptionDetail");
            modelBuilder.Entity<AppointmentVeterinarian>().ToTable("AppointmentVeterinarian");
            modelBuilder.Entity<Message>().ToTable("Message");
            #endregion

            #region Relationships and Additional Configuration

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

            // OrderItem relationships
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Pet)
                .WithMany()
                .HasForeignKey(oi => oi.PetId)
                .OnDelete(DeleteBehavior.Restrict);

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

            // PetServiceCategory has many PetServices
            modelBuilder.Entity<PetServiceCategory>()
                .HasMany(psc => psc.PetServices)
                .WithOne(ps => ps.PetServiceCategory)
                .HasForeignKey(ps => ps.PetServiceCategoryId);

            // ComboService -> ComboServiceItem (1-to-many)
            modelBuilder.Entity<ComboService>()
                .HasMany(c => c.ComboServiceItems)
                .WithOne(csi => csi.ComboService)
                .HasForeignKey(csi => csi.ComboServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Appointment relationships
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Customer)
                .WithMany(u => u.Appointments)
                .HasForeignKey(a => a.CustomerId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Pet)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PetId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.PetService)
                .WithMany()
                .HasForeignKey(a => a.PetServiceId);

            modelBuilder.Entity<Appointment>()
                .HasMany(av => av.AppointmentVeterinarians)
                .WithOne(a => a.Appointment)
                .HasForeignKey(av => av.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Veterinarian and User one-to-one relationship
            modelBuilder.Entity<Veterinarian>()
                .HasOne(v => v.User)
                .WithOne(u => u.Veterinarian)
                .HasForeignKey<Veterinarian>(v => v.UserId);

            // Veterinarian has many schedules
            modelBuilder.Entity<VeterinarianSchedule>()
                .HasOne(vs => vs.Veterinarian)
                .WithMany(v => v.VeterinarianSchedules)
                .HasForeignKey(vs => vs.VeterinarianId);

            // PetService -> ComboServiceItem (1-to-many)
            modelBuilder.Entity<PetService>()
                .HasMany(ps => ps.ComboServiceItems)
                .WithOne(csi => csi.PetService)
                .HasForeignKey(csi => csi.PetServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            // PrescriptionDetail and Product - many-to-one relationship
            modelBuilder.Entity<PrescriptionDetail>()
                .HasOne(pd => pd.Medicine)
                .WithMany()
                .HasForeignKey(pd => pd.MedicineId)
                .OnDelete(DeleteBehavior.Restrict);

            // ServiceReport has a one-to-one relationship with Prescription
            modelBuilder.Entity<ServiceReport>()
                .HasOne(sr => sr.Prescription)
                .WithOne(p => p.ServiceReport)
                .HasForeignKey<Prescription>(p => p.ServiceReportId)
                .OnDelete(DeleteBehavior.Cascade);

            // ServiceReport has one Appointment (foreign key relationship)
            modelBuilder.Entity<ServiceReport>()
                .HasOne(sr => sr.Appointment)
                .WithMany()
                .HasForeignKey(sr => sr.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.ServiceReport)
                .WithOne(sr => sr.Appointment)
                .HasForeignKey<ServiceReport>(sr => sr.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);


            #endregion
        }
    }
}

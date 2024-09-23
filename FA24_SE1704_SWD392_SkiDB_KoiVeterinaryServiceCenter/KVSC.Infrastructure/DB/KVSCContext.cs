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
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");

            //Add-Migration init -Context KVSCContext -Project KVSC.Infrastructure -StartupProject KVSC.WebAPI -OutputDir DB/Migrations
            base.OnModelCreating(modelBuilder);
        }
        }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Domain.Entities;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData
                (
                new Role
                {
                    RoleId = 1,
                    RoleName = "Admin"
                },
                 new Role
                 {
                     RoleId = 2,
                     RoleName = "Manager"
                 },
                  new Role
                  {
                      RoleId = 3,
                      RoleName = "Veterinarian"
                  },
                  new Role
                  {
                      RoleId = 4,
                      RoleName = "Staff"
                  },
                  new Role
                  {
                      RoleId = 5,
                      RoleName = "Customer"
                  }

                );
        }
    }
}

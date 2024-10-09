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
                    RoleName = "admin"
                },
                 new Role
                 {
                     RoleId = 2,
                     RoleName = "manager"
                 },
                  new Role
                  {
                      RoleId = 3,
                      RoleName = "veterinarian"
                  },
                  new Role
                  {
                      RoleId = 4,
                      RoleName = "staff"
                  },
                  new Role
                  {
                      RoleId = 5,
                      RoleName = "customer"
                  }

                );
        }
    }
}

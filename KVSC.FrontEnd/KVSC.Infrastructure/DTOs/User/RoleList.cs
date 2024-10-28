using KVSC.Infrastructure.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.User
{
    public class RoleList
    {
        public Extensions<List<Role>> Extensions { get; set; }
    }

    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
    }
}

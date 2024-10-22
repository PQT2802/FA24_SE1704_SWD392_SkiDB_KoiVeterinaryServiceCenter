using KVSC.Infrastructure.DTOs.User.Login;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.User
{
    public class UserInfo
    {
        public Extensions<Data> Extensions { get; set; }
    }

    public class Data
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public string? Avatar { get; set; }  // Nullable Avatar field
        public string? PhoneNumber { get; set; }  // Nullable PhoneNumber field
        public string? Address { get; set; }  // Nullable Address field
    }

}

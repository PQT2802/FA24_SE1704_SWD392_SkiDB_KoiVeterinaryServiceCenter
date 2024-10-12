using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs;

namespace KVSC.Infrastructure.DTOs.User.Login
{
    public class LoginResponse
    {
        public Extensions<LoginData> Extensions { get; set; }
    }
    public class LoginData
    {
        public string ReNewToken { get; set; }
        public string AccessToken { get; set; }
    }
}

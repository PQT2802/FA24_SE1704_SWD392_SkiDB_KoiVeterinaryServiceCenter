using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.User.Register
{
    public class SignUpRequest
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? LicenseNumber { get; set; } // Số giấy phép hành nghề
        public string? Specialty { get; set; } // Chuyên môn
        public IFormFile? Qualifications { get; set; } // Học vị/chứng chỉ
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.User.GetUser
{
    public class VeterinarianResponse
    {
        public Guid UserId { get; set; }
        public string LicenseNumber { get; set; }
        public string Specialty { get; set; } 
        public string Qualifications { get; set; }

    }
}

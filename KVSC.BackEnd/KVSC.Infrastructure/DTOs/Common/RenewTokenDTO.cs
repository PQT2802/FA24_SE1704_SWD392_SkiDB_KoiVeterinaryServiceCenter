﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Common
{
    public class RenewTokenDTO
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}

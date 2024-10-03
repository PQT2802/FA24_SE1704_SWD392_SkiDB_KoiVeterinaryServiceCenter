﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.ICommon
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
        bool VerifyPassword(string providedPassword, string hashedPassword);
    }
}

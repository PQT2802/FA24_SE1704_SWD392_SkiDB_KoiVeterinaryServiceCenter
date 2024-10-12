﻿using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IUserService
    {
        Task<Result> GetUserByEmail(string email);
    }
}

﻿using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.KVSC.Application.Implement.Service
{
    public class UserService
    {
        private readonly UnitOfWork _unitOfWork;
        public UserService(UnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        
        }
        

    }
}

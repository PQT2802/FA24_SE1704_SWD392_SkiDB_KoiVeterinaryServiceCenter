using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class AuthService : IAuthService
    {
        private readonly UnitOfWork _unitOfWork;
        public AuthService(UnitOfWork unitOfWork ) 
        {
        _unitOfWork = unitOfWork;
        }

        public Task<Result> SignIn(LoginRequest loginRequest)
        {
            throw new NotImplementedException();
        }
    }
}

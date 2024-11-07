using Google.Apis.Auth;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IAuthService
    {
        Task<Result> SignIn(LoginRequest loginRequest);
        Task<Result> SignUp(RegisterRequest registerRequest);
        Task<Result> ConfirmEmail(Guid userId);
        public string GenerateJwtToken(string email, int Role, double expirationMinutes);
        public Task<User> FindOrCreateUser(GoogleJsonWebSignature.Payload payload);
      
    }
}

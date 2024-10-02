using KVSC.Infrastructure.DTOs.Login;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Interface
{
    public interface IAuthService
    {
        Task<ResponseDto<LoginResponse>> SignIn(LoginRequest loginRequest);
        public Task<ResponseDto<LoginResponse>> GoogleSignIn(GoogleSignInRequest googleSignInRequest);

    }
}

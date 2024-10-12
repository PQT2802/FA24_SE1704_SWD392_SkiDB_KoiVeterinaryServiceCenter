using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.DTOs.User;

namespace KVSC.Infrastructure.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<ResponseDto<LoginResponse>> SignIn(LoginRequest loginRequest);
        public Task<ResponseDto<LoginResponse>> GoogleSignIn(GoogleSignInRequest googleSignInRequest);
        Task<ResponseDto<SignUpResponse>> SignUp(SignUpRequest signUpRequest);
        Task<ResponseDto<UserInfo>> GetUserInforByToken(string token);
    }
}

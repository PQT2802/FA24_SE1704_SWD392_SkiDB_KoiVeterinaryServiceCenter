using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Login;
using KVSC.Infrastructure.Repositories.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Implement
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        public AuthService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public async Task<ResponseDto<LoginResponse>> SignIn(LoginRequest loginRequest)
        {
            var response = await _userRepository.SignIn(loginRequest);
            return response;
        }
        public async Task<ResponseDto<LoginResponse>> GoogleSignIn(GoogleSignInRequest googleSignInRequest)
        {
            // Gửi yêu cầu đến API để xác thực Google ID Token
            var response = await _userRepository.GoogleSignIn(googleSignInRequest);
            return response;
        }
    }
}

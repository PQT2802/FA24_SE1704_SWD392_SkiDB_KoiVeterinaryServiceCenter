using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.Repositories.Interface;

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

        public async Task<ResponseDto<SignUpResponse>> SignUp(SignUpRequest signUpRequest)
        {
            var response = await _userRepository.SignUp(signUpRequest);
            return response;
        }

        public async Task<ResponseDto<UserInfo>> GetUserInforByToken(string token)
        {
            var response = await _userRepository.GetUserInforByToken(token);
            return response;
        }
    }
}

using Google.Apis.Auth;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Application.KVSC.Application.Implement.Service;
using KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService) 
        {
           _authService = authService;
        }

        [HttpPost("sign-in")]
        public async Task<IResult> SignInForUser(LoginRequest loginRequest)
        {
            Result result = await _authService.SignIn(loginRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Login successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpPost("sign-up")]
        public async Task<IResult> RegisterForUser([FromBody] RegisterRequest registerRequest)
        {
            Result result = await _authService.SignUp(registerRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Register successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("confirm")]
        public async Task<IActionResult> ConfirmEmail(Guid userId)
        {
            Result result = await _authService.ConfirmEmail(userId);

            if (result.IsSuccess)
            {
                return Redirect("https://localhost:7241/Account/SignIn");
            }

            return (IActionResult)ResultExtensions.ToProblemDetails(result);
        }




        [HttpPost("google-sign-in")]
        public async Task<IActionResult> GoogleSignIn([FromBody] GoogleSignInRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.IdToken))
            {
                return BadRequest("ID token is required.");
            }

            try
            {
                // Validate the ID token with Google
                var payload = await GoogleJsonWebSignature.ValidateAsync(request.IdToken);

                // Tìm hoặc tạo người dùng trong hệ thống của bạn
                var user = await _authService.FindOrCreateUser(payload);

                // Tạo JWT token cho người dùng (nếu cần)
                var token = _authService.GenerateJwtToken(user.Email, 2, 120); // Bạn cần triển khai phương thức này

                return Ok(new { Token = token, User = user });
            }
            catch (Exception ex)
            {
                return BadRequest($"Google sign-in failed: {ex.Message}");
            }
        }
    }
}

using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
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


    }
}

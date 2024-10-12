using FluentValidation;
using KVSC.Application.Common;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LoginRequest = Microsoft.AspNetCore.Identity.Data.LoginRequest;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IUserService _userService;
        public UserController (IHttpContextAccessor contextAccessor,IUserService userService)
        {
            _contextAccessor = contextAccessor;
            _userService = userService;
        }


        [HttpGet("user-infor")]
        public async Task<IResult> GetUserInfor()
        {
            CurrentUserObject c = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _userService.GetUserByEmail(c.Email);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Register successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

    }
}

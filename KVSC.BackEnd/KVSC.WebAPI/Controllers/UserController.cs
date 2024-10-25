using Azure.Core;
using FluentValidation;
using KVSC.Application.Common;
using KVSC.Application.Implement.Service;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.DTOs.PetService;
using KVSC.Infrastructure.DTOs.User.AddUser;
using KVSC.Infrastructure.DTOs.User.GetUser;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
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

        [Authorize]
        [HttpGet("user-infor")]
        public async Task<IResult> GetUserInfor()
        {
            CurrentUserObject c = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _userService.GetUserByEmail(c.Email);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Register successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        /*====================================CRUD user=============================*/
        [HttpGet("users/search")]
        public async Task<IResult> GetAllUsers(
        [FromQuery] string? fullName = null,
        [FromQuery] string? email = null,
        [FromQuery] string? phoneNumber = null,
        [FromQuery] string? address = null,
        [FromQuery] DateTime? dateOfBirth = null,
        [FromQuery] int? role = null,
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10)
        {
            var result = await _userService.GetAllUsersAsync(
                fullName, email, phoneNumber, address, dateOfBirth, role, pageNumber, pageSize);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "All users retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        //[HttpPost]
        //public async Task<IResult> CreateUser([FromBody] AddUserRequest addUserRequest)
        //{
        //    var result = await _userService.CreateUserAsync(addUserRequest);
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "User created successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}

        [HttpPost("upload/img")]
        public async Task<IResult> UploadImage([FromForm] UploadImageRequest request)
        {
            var result = await _userService.UploadImageAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Image uploaded successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }


        [HttpGet]
        public async Task<IResult> GetUserById([FromQuery] GetUserRequest request)
        {
            var result = await _userService.GetUserByIdAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "User retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpPut]
        public async Task<IResult> UpdateUser([FromBody] UpdateUserRequest updateUserRequest)
        {
            var result = await _userService.UpdateUserAsync(updateUserRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "User updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpDelete]
        public async Task<IResult> DeleteUser([FromQuery] GetUserRequest request)
        {
            var result = await _userService.DeleteUserAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "User deleted successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("roleList")]
        public async Task<IResult> GetAllRoles()
        {
            var result = await _userService.GetAllRolesAsync();
            return result.IsSuccess
               ? ResultExtensions.ToSuccessDetails(result, "All roles retrieved successfully")
               : ResultExtensions.ToProblemDetails(result);
        }
    }
}

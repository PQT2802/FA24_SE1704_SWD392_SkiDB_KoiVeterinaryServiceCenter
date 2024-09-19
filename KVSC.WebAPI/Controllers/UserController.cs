﻿using FluentValidation;
using KVSC.Domain.Entities.User;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IValidator<User> _userValidator;

        public UserController(IValidator<User> userValidator)
        {
            _userValidator = userValidator;
        }


        [HttpPost]

        public async Task<IActionResult> CreateUser(User user)
        {
            var validationResult = await _userValidator.ValidateAsync(user);

            if (!validationResult.IsValid)
            {
                // Trả về lỗi nếu email đã tồn tại hoặc có lỗi khác
                return BadRequest(validationResult.Errors);
            }

            // Xử lý khi user hợp lệ
            return Ok("User is valid.");
        }
        [HttpPost("Login")]
        public async Task<IActionResult> LoginTest(Login.Request user)
        {
            if (user.Email.Equals("a") && user.Password.Equals("2"))
            // Xử lý khi user hợp lệ
            return Ok("User is valid.");
            return BadRequest("Invalid");
        }
    }
}

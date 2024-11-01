﻿using FluentValidation;
using Google.Apis.Auth;
using KVSC.Application.Interface.ICommon;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.Common;
using KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<RegisterRequest> _registerRequestValidator;
        private readonly IValidator<LoginRequest> _loginRequestValidator;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IConfiguration _configuration;
        private readonly ITokenService _tokenService;


        public AuthService(
            IUnitOfWork unitOfWork,
            IValidator<RegisterRequest> registerRequestValidator,
            IValidator<LoginRequest> loginRequestValidator,
            IPasswordHasher passwordHasher,
            ITokenService tokenService,
            IConfiguration configuration
            )
        {
            _unitOfWork = unitOfWork;
            _registerRequestValidator = registerRequestValidator;
            _loginRequestValidator = loginRequestValidator;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
            _configuration = configuration;
        }

        public async Task<Result> SignIn(LoginRequest loginRequest)
        {
            var validate = await _loginRequestValidator.ValidateAsync(loginRequest);
            if (!validate.IsValid)
            {
                var errors = validate.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();

                // Handle errors as needed, e.g., return them in a Result object
                return Result.Failures(errors);
            }
            var userLogin = await _unitOfWork.UserRepository.GetUserByEmailAndPasswordAsync(loginRequest.Email, loginRequest.Password); 
            
            if (userLogin == null)
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }
            var role = userLogin.role switch
            {
                1 => "Admin",
                2 => "Manager",
                3 => "Veterinarian",
                4 => "Staff",
                5 => "Customer",
                _ => throw new InvalidOperationException("Unknown role.")
            };
            var c = new CurrentUserObject
            {
                UserId = userLogin.Id,
                Fullname = userLogin.FullName,
                Email = userLogin.Email,
                Phone = userLogin.PhoneNumber,
                RoleName = role,
            };
            var token = await _tokenService.GenerateTokenAsync(c);
            var accessToken = await _tokenService.GenerateAccessTokenAsync(token);
            //var accessToken =  GenerateJwtToken(c.Email, c.RoleId, 180);
            var loginResponse = new LoginResponse
            {
                ReNewToken = "Test",
                AccessToken = accessToken,
            };

            return Result.SuccessWithObject(loginResponse);
        }

        public async Task<Result> SignUp(RegisterRequest registerRequest)
        {
            var validate = await _registerRequestValidator.ValidateAsync(registerRequest);
            if (!validate.IsValid)
            {
                var errors = validate.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            var passwordHash = HashPassword(registerRequest.Password);
            User newUser = new User
            {
                Id = Guid.NewGuid(),
                FullName = registerRequest.FullName,
                Email = registerRequest.Email,
                PasswordHash = registerRequest.Password,
                Username = registerRequest.UserName,
                PhoneNumber = registerRequest.PhoneNumber,
                Address = registerRequest.Address,
                DateOfBirth = registerRequest.DateOfBirth,
                role = 5,
                
            };
            //Wallet newWallet = new Wallet()
            //{
            //    UserId = newUser.Id,
            //    Amount = 0,
            //};
            //await _unitOfWork.WalletRepository.CreateAsync(newWallet);
            var createUsre = await _unitOfWork.UserRepository.CreateAsync(newUser);
            if (createUsre == 0)
            {
                return Result.Failure(UserErrorMessage.UserNoCreated());
            }
            return Result.SuccessWithObject(newUser);
        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public  string GenerateJwtToken(string email, int Role, double expirationMinutes)//them tham so role de phan quyen
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            // add role to author
            var role = Role switch
            {
                1 => "Admin",
                2 => "Customer",
                3 => "Staff",
                4 => "Manager"
            };
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, role)// claim role
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(expirationMinutes),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<User> FindOrCreateUser(GoogleJsonWebSignature.Payload payload)
        {
            var user  = await _unitOfWork.UserRepository.GetByAsync("Email", payload.Email);
            if (user == null)
            {
                user = new User
                {
                    Id = Guid.NewGuid(),
                    Email = payload.Email,
                    FullName = payload.Name,
                };
                await _unitOfWork.UserRepository.CreateAsync(user);
            }
            return user;
        }
    }
}
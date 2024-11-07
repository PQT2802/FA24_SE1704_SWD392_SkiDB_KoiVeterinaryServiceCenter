using FluentValidation;
using Google.Apis.Auth;
using KVSC.Application.Interface.ICommon;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.Common;
using KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.EmailTemplate;
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
        private readonly IEmailService _emailService;
        private readonly IEmailTemplateService _emailTemplateService;

        public AuthService(
            IUnitOfWork unitOfWork,
            IValidator<RegisterRequest> registerRequestValidator,
            IValidator<LoginRequest> loginRequestValidator,
            IPasswordHasher passwordHasher,
            ITokenService tokenService,
            IConfiguration configuration,
            IEmailService emailService,
            IEmailTemplateService emailTemplateService
            )
        {
            _unitOfWork = unitOfWork;
            _registerRequestValidator = registerRequestValidator;
            _loginRequestValidator = loginRequestValidator;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
            _configuration = configuration;
            _emailService = emailService;
            _emailTemplateService = emailTemplateService;
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
            if (!userLogin.IsEmailConfirmed)
            {
                return Result.Failure(Error.NotFound("Confirm", "Your email is not activated yet!!, please confirm your mail"));
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
            Wallet newWallet = new Wallet()
            {
                UserId = newUser.Id,
                Amount = 0,
            };
            
            var createUsre = await _unitOfWork.UserRepository.CreateAsync(newUser);
            if (createUsre == 0)
            {
                return Result.Failure(UserErrorMessage.UserNoCreated());
            }

            await _unitOfWork.WalletRepository.CreateAsync(newWallet);
            

            var activationLink = $"https://localhost:7283/api/Auth/confirm?userId={newUser.Id}";

            // Send activation email
            var emailBodyResult = await _emailTemplateService.GenerateEmailWithActivationLink("VerifyEmail", activationLink);
            if (emailBodyResult.IsFailure)
            {
                return Result.Failure(Error.Failure("EmailGenerationFailed", "Failed to generate the email body."));
            }
            var emailBody = emailBodyResult.Object as string;

            // Create and send the email
            var mailObject = new MailObject
            {
                ToMailIds = new List<string> { newUser.Email },
                Subject = "Confirm Your Email Address",
                Body = emailBody,
                IsBodyHtml = true
            };

            var sendResult = await _emailTemplateService.SendMail(mailObject);
            if (!sendResult.IsSuccess)
            {
                return Result.Failure(Error.None);
            }
            return Result.SuccessWithObject(new { Message = "Create successfully!!!" });

        }

        public async Task<Result> ConfirmEmail(Guid userId)
        {
            var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
            if (user == null)
            {
                return Result.Failure(Error.NotFound("UserNotFound", "User not found."));
            }

            user.IsEmailConfirmed = true;
            await _unitOfWork.UserRepository.UpdateAsync(user);

            return Result.Success();
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
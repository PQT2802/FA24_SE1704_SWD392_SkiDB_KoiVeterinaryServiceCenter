using FluentValidation;
using KVSC.Application.Interface.ICommon;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Domain.Enum;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;

namespace KVSC.Application.Implement.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<RegisterRequest> _registerRequestValidator;
        private readonly IValidator<LoginRequest> _loginRequestValidator;
        private readonly IPasswordHasher _passwordHasher;

        public AuthService(
            IUnitOfWork unitOfWork,
            IValidator<RegisterRequest> registerRequestValidator,
            IValidator<LoginRequest> loginRequestValidator,
            IPasswordHasher passwordHasher
            )
        {
            _unitOfWork = unitOfWork;
            _registerRequestValidator = registerRequestValidator;
            _loginRequestValidator = loginRequestValidator;
            _passwordHasher = passwordHasher;
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
            var userLogin = await _unitOfWork.UserRepository.GetByAsync("Email", loginRequest.Email); // fixxxxxxxxxx
            var checkPassword = _passwordHasher.VerifyPassword(loginRequest.Password, userLogin.PasswordHash);
            if (userLogin == null || checkPassword == false)
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }

            var loginResponse = new LoginResponse
            {
                ReNewToken = "Test",
                AccessToken = "Test",
            };

            return Result.SuccessWithObject(loginResponse);

        }

        public async Task<Result> SignUp(RegisterRequest registerRequest)
        {
            // Validate the registration request
            var validate = await _registerRequestValidator.ValidateAsync(registerRequest);
            if (!validate.IsValid)
            {
                var errors = validate.Errors
                    .Select(e => new Error("VALIDATION_FAILED", e.ErrorMessage, ErrorType.Validation)) // Use Validation error type
                    .ToList();
                return Result.Failures(errors); // Return list of validation errors
            }

            // Create a new User
            User newUser = new User
            {
                Id = Guid.NewGuid(),
                Email = registerRequest.Email,
                PasswordHash = _passwordHasher.HashPassword(registerRequest.Password),
                Username = registerRequest.UserName,
                Address = registerRequest.Address,
            };

            var createUserResult = await _unitOfWork.UserRepository.CreateAsync(newUser);
            if (createUserResult == 0)
            {
                return Result.Failure(new Error("USER_CREATE_FAILED", "User creation failed.", ErrorType.Failure)); // Failure error type
            }

            // Create a Cart for the new User
            Cart newCart = new Cart
            {
                Id = Guid.NewGuid(),
                UserId = newUser.Id,
                User = newUser
            };

            var createCartResult = await _unitOfWork.CartRepository.CreateAsync(newCart);
            if (createCartResult == 0)
            {
                return Result.Failure(new Error("CART_CREATE_FAILED", "Failed to create cart for the user.", ErrorType.Failure)); // Failure error type
            }

            // Success - Return user and cart as part of the result
            return Result.SuccessWithObject(newUser);
        }




    }
}
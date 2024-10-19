using Azure;
using Azure.Core;
using FluentValidation;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Paging;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.AddUser;
using KVSC.Infrastructure.DTOs.User.GetUser;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.KVSC.Application.Implement.Service
{
    public class UserService : IUserService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly IValidator<AddUserRequest> _userValidator;
        private readonly IValidator<UpdateUserRequest> _updateUserValidator;

        public UserService(UnitOfWork unitOfWork, IValidator<AddUserRequest> userValiator, IValidator<UpdateUserRequest> updateUserValidator) 
        {
            _unitOfWork = unitOfWork;
            _userValidator = userValiator;
            _updateUserValidator = updateUserValidator;
        }

        public async Task<Result> GetUserByEmail(string email)
        {
            var user = await _unitOfWork.UserRepository.GetByAsync("Email", email);
            if (user == null) 
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }
            var userInfor = new UserInfor
            {
                UserName = user.Username,
                Email = user.Email,
                Avatar = user.ProfilePictureUrl,
                RoleName = user.role switch
                {
                    1 => "Admin",
                    2 => "Manager",
                    3 => "Veterinarian",
                    4 => "Staff",
                    5 => "Customer",
                    _ => throw new InvalidOperationException("Unknown role.")
                }
            };
            
            return Result.SuccessWithObject(userInfor);
        }

        public async Task<Result> GetAllUsersAsync(
        string? fullName = null,
        string? email = null,
        string? phoneNumber = null,
        string? address = null,
        DateTime? dateOfBirth = null,
        int? role = null,
        int pageNumber = 1,
        int pageSize = 10)
        {
            var (users, totalCount) = await _unitOfWork.UserRepository.GetAllUsersAsync(
                fullName, email, phoneNumber, address, dateOfBirth, role, pageNumber, pageSize);

            var response = new PagedResponse<GetUserResponse>
            {
                Data = users,
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return Result.SuccessWithObject(response);
        }
        public async Task<Result> CreateUserAsync(AddUserRequest request)
        {
            var validationResult = await _userValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => (Error)e.CustomState).ToList();
                return Result.Failures(errors);
            }

            var user = new User
            {
                FullName = request.FullName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                Username = request.UserName,
                PasswordHash = request.Password,
                ProfilePictureUrl = request.ProfilePictureUrl,
                DateOfBirth = request.DateOfBirth,
                role = request.Role,
                CreatedDate = DateTime.UtcNow,
            };

            var createResult = await _unitOfWork.UserRepository.CreateUserAsync(user);
            if (createResult == null)
            {
                return Result.Failure(UserErrorMessage.UserNoCreated());
            }
            var response = new CreateResponse { Id = user.Id };
            return Result.SuccessWithObject(response);
        }
        public async Task<Result> GetUserByIdAsync(Guid id)
        {
            var user = await _unitOfWork.UserRepository.GetUserByIdAsync(id);
            if (user == null)
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }
            var response = new GetUserResponse
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                ProfilePictureUrl = user.ProfilePictureUrl,
                Address = user.Address,
                Role = user.role
            };
            return Result.SuccessWithObject(response);
        }
        public async Task<Result> UpdateUserAsync(UpdateUserRequest request)
        {
            var validationResult = await _updateUserValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }
            var user = await _unitOfWork.UserRepository.GetUserByIdAsync(request.Id);
            if (user == null)
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }

            user.FullName = request.FullName;
            user.Username = request.UserName;
            user.Email = request.Email;
            user.PhoneNumber = request.PhoneNumber;
            user.Address = request.Address;
            user.ProfilePictureUrl = request.ProfilePictureUrl;
            user.DateOfBirth = request.DateOfBirth;
            user.role = request.Role;
            user.ModifiedDate = DateTime.UtcNow;

            var updateResult = await _unitOfWork.UserRepository.UpdateAsync(user);
            if (updateResult == 0)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceUpdateFailed());
            }
            var response = new CreateResponse { Id = user.Id };
            return Result.SuccessWithObject(response);
        }
        public async Task<Result> DeleteUserAsync(Guid id)
        {
            var result = await _unitOfWork.UserRepository.DeleteUserAsync(id);
            if (result == 0)
            {
                return Result.Failure(UserErrorMessage.UserDeleteFailed());
            }
            return Result.SuccessWithObject(result);
        }
        public async Task<Result> GetAllRolesAsync()
        {
            var result = await _unitOfWork.UserRepository.GetAllRolesAsync();

            return Result.SuccessWithObject(result);
        }
    }
}

using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.PetService;
using KVSC.Infrastructure.DTOs.User.AddUser;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IUserService
    {
        Task<Result> GetUserByEmail(string email);
        Task<Result> GetAllUsersAsync(
        string? fullName = null,
        string? email = null,
        string? phoneNumber = null,
        string? address = null,
        DateTime? dateOfBirth = null,
        int? role = null,
        int pageNumber = 1,
        int pageSize = 10);
        Task<Result> CreateUserAsync(AddUserRequest addUserRequest);
        Task<Result> GetUserByIdAsync(Guid id);
        Task<Result> UpdateUserAsync(UpdateUserRequest updateUserRequest);

        Task<Result> DeleteUserAsync(Guid id);
        Task<Result> GetAllRolesAsync();
        Task<Result> UploadImageAsync(UploadImageRequest request);
        Task<Result> UpdateVeterinarianAsync(Guid userId, UpdateVeterinarianRequest request);
        Task<Result> GetVeterinarianByIdAsync(Guid id);
        Task<Result> GetUserByVeterId(Guid veterinarianid);
        Task<Result> GetAllVeterinarians();
        Task<Result> CreateVeterinarianAsync(CreateVeterinarianRequest request);
    }
}

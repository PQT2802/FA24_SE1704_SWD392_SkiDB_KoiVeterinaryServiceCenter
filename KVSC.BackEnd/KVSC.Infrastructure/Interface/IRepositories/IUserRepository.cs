using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.User.GetUser;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<bool> UserNameExistsAsync(string userName);
        Task<bool> EmailExistsAsync(string email);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string password);
        Task<User> GetUserByNameAsync(string userName);
        Task<User> CreateUserAsync(User user);
        Task<User> GetUserByIdAsync(Guid id);
        Task<int> DeleteUserAsync(Guid id);
        Task<(List<GetUserResponse> Users, int TotalCount)> GetAllUsersAsync(
        string? fullName = null,
        string? email = null,
        string? phoneNumber = null,
        string? address = null,
        DateTime? dateOfBirth = null,
        int? role = null,
        int pageNumber = 1,
        int pageSize = 10);
        Task<List<Role>> GetAllRolesAsync();

        Task<int> UpdateVeterinarianAsync(Veterinarian veterinarian);
    }
}

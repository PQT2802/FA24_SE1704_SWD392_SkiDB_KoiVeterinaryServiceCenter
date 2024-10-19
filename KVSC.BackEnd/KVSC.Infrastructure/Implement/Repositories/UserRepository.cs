using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.DTOs.User.GetUser;
using KVSC.Infrastructure.Interface.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        
        public UserRepository(KVSCContext context) : base(context) { }

        #region bool
        public async Task<bool> UserNameExistsAsync(string userName)
        {
            // Check if any user exists with the specified username
            return await _context.Users.AnyAsync(x => x.Username == userName);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            // Check if any user exists with the specified email
            return await _context.Users.AnyAsync(x => x.Email == email);
        }
        #endregion

        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email.Equals(email) && x.PasswordHash.Equals(password));
        }

        public async Task<User> GetUserByNameAsync(string userName)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == userName);
        }
        /*======================================CRUD USER======================================*/
        public async Task<User> CreateUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _context.Users
                .Where(u => u.Id == id && !u.IsDeleted)
                .FirstOrDefaultAsync();
        }
        public async Task<(List<GetUserResponse> Users, int TotalCount)> GetAllUsersAsync(
        string? fullName = null,
        string? email = null,
        string? phoneNumber = null,
        string? address = null,
        DateTime? dateOfBirth = null,
        int? role = null,
        int pageNumber = 1,
        int pageSize = 10)
        {
            var query = _context.Users.AsQueryable();

            // Filtering
            if (!string.IsNullOrWhiteSpace(fullName))
                query = query.Where(u => u.FullName.Contains(fullName));

            if (!string.IsNullOrWhiteSpace(email))
                query = query.Where(u => u.Email.Contains(email));

            if (!string.IsNullOrWhiteSpace(phoneNumber))
                query = query.Where(u => u.PhoneNumber.Contains(phoneNumber));

            if (!string.IsNullOrWhiteSpace(address))
                query = query.Where(u => u.Address.Contains(address));

            if (dateOfBirth.HasValue)
                query = query.Where(u => u.DateOfBirth.Date == dateOfBirth.Value.Date);

            if (role.HasValue)
                query = query.Where(u => u.role == role.Value);

            query = query.Where(u => !u.IsDeleted);

            // Total count before pagination
            int totalCount = await query.CountAsync();

            // Apply paging
            // Apply paging
            var users = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(u => new GetUserResponse
                {
                    Id = u.Id,
                    FullName = u.FullName,
                    Username = u.Username, // Chỉnh sửa tên thuộc tính thành chữ hoa
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    ProfilePictureUrl = u.ProfilePictureUrl,
                    Address = u.Address,
                    DateOfBirth = u.DateOfBirth,
                    CreatedDate = u.CreatedDate,
                    Role = u.role
                })
                .ToListAsync();

            return (users, totalCount);
        }
        public async Task<int> DeleteUserAsync(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return 0;

            user.IsDeleted = true;
            _context.Users.Update(user);
            return await _context.SaveChangesAsync();
        }
        public async Task<List<Role>> GetAllRolesAsync()
        {
            return await _context.Roles.ToListAsync();
        }
    }
}

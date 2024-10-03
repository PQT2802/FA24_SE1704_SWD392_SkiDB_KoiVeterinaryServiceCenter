using KVSC.Domain.Entities;
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
    }
}

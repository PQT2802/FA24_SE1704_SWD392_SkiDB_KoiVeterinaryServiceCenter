using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Interface
{
    public interface IUserService
    {
        Task<ResponseDto<UserList>> GetUserList(string fullName, string email, string phoneNumber, string address, int role, int pageNumber, int pageSize);
        Task<ResponseDto<RoleList>> GetRoleList();

    }
}

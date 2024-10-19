using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Service.ServiceDetail;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.Repositories.Implement;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using KVSC.Infrastructure.DTOs.User.DeleteUser;

namespace KVSC.Application.Service.Implement
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<ResponseDto<UserList>> GetUserList(string fullName, string email, string phoneNumber, string address, int role, int pageNumber, int pageSize)
        {
            return await _userRepository.GetUserList(fullName, email, phoneNumber, address, role, pageNumber, pageSize);
        }
        public async Task<ResponseDto<RoleList>> GetRoleList()
        {
            return await _userRepository.GetRoleList();
        }
        public async Task<ResponseDto<UpdateUserResponse>> UpdateUser(UpdateUserRequest request)
        {
            request.FullName = string.IsNullOrWhiteSpace(request.FullName) ? string.Empty : request.FullName;
            request.UserName = string.IsNullOrWhiteSpace(request.UserName) ? string.Empty : request.UserName;
            request.Email = string.IsNullOrWhiteSpace(request.Email) ? string.Empty : request.Email;
            request.Address = string.IsNullOrWhiteSpace(request.Address) ? string.Empty : request.Address;
            request.ProfilePictureUrl = string.IsNullOrWhiteSpace(request.ProfilePictureUrl) ? string.Empty : request.ProfilePictureUrl;

            var response = await _userRepository.UpdateUser(request);
            return response;
        }
        public async Task<ResponseDto<DeleteUserResponse>> DeleteUser(DeleteUserRequest request)
        {
            var response = await _userRepository.DeleteUser(request);
            return response;
        }
    }
}

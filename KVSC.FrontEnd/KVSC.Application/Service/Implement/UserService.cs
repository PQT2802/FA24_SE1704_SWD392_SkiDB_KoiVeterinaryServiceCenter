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
using KVSC.Infrastructure.DTOs.User.GetUser;
using Microsoft.AspNetCore.Http;

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
        public async Task<ResponseDto<UpdateUserResponse>> UpdateUser(UpdateUserRequest request, IFormFile imageFile)
        {
            request.FullName = string.IsNullOrWhiteSpace(request.FullName) ? string.Empty : request.FullName;
            request.UserName = string.IsNullOrWhiteSpace(request.UserName) ? string.Empty : request.UserName;
            request.Email = string.IsNullOrWhiteSpace(request.Email) ? string.Empty : request.Email;
            request.Address = string.IsNullOrWhiteSpace(request.Address) ? string.Empty : request.Address;
            request.PhoneNumber = string.IsNullOrWhiteSpace(request.PhoneNumber) ? string.Empty : request.PhoneNumber;
            request.ProfilePictureUrl = string.IsNullOrWhiteSpace(request.ProfilePictureUrl) ? string.Empty : request.ProfilePictureUrl;

            var response = await _userRepository.UpdateUser(request, imageFile);
            return response;
        }
        public async Task<ResponseDto<DeleteUserResponse>> DeleteUser(DeleteUserRequest request)
        {
            var response = await _userRepository.DeleteUser(request);
            return response;
        }
        public async Task<ResponseDto<GetUserResponse>> GetUserDetail(Guid id)
        {
            var response = await _userRepository.GetUserDetail(id);
            return response;
        }


        public Task<ResponseDto<GetVetId>> GetVetForAppoinment()
        {
            throw new NotImplementedException();
        }
        public async Task<ResponseDto<GetVeterinarianResponse>> GetVeterinarianDetail(Guid id)
        {
            var response = await _userRepository.GetVeter(id);
            return response;
        }
        public async Task<ResponseDto<UpdateUserResponse>> UpdateVeterinarianQualifications(GetVeterinarianRequest updatedProfile)
        {
            updatedProfile.Qualifications = string.IsNullOrWhiteSpace(updatedProfile.Qualifications) ? string.Empty : updatedProfile.Qualifications;
            updatedProfile.LicenseNumber = string.IsNullOrWhiteSpace(updatedProfile.LicenseNumber) ? string.Empty : updatedProfile.LicenseNumber;
            updatedProfile.Specialty = string.IsNullOrWhiteSpace(updatedProfile.Specialty) ? string.Empty : updatedProfile.Specialty;
            return await _userRepository.UpdateVeterinarianQualificationsAsync(updatedProfile);

        }
    }
}

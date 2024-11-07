
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.User.DeleteUser;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using KVSC.Infrastructure.DTOs.User.GetUser;
using Microsoft.AspNetCore.Http;
using KVSC.Infrastructure.DTOs.User;

namespace KVSC.Application.Service.Interface
{
    public interface IUserService
    {
        Task<ResponseDto<UserList>> GetUserList(string fullName, string email, string phoneNumber, string address, int role, int pageNumber, int pageSize);
        Task<ResponseDto<RoleList>> GetRoleList();
        Task<ResponseDto<DeleteUserResponse>> DeleteUser(DeleteUserRequest request);
        Task<ResponseDto<UpdateUserResponse>> UpdateUser(UpdateUserRequest request, IFormFile imageFile);
        Task<ResponseDto<GetUserResponse>> GetUserDetail(Guid id);
        Task<ResponseDto<GetVeterinarianResponse>> GetVeterinarianDetail(Guid id);
        Task<ResponseDto<UpdateUserResponse>> UpdateVeterinarianQualifications(GetVeterinarianRequest updatedProfile);

        Task<ResponseDto<GetVetId>> GetVetForAppoinment();
        Task<ResponseDto<AddMoney>> TopUpWallet(string token, decimal amount);
        Task<ResponseDto<GetVetInfo>> GetVetList();
        Task<ResponseDto<UpdateUserResponse>> CreateVeterinarian(GetVeterinarianRequest createRequest);
        Task<ResponseDto<Payment>> GetPaymentOfUser(string token);
        Task<ResponseDto<CommonMessage>> CompletePayment(string token, Guid paymentId);
    }
}

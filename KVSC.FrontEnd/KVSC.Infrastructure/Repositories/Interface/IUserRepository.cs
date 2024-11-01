using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.DeleteUser;
using KVSC.Infrastructure.DTOs.User.GetUser;
using KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using Microsoft.AspNetCore.Http;

namespace KVSC.Infrastructure.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<ResponseDto<LoginResponse>> SignIn(LoginRequest loginRequest);
        public Task<ResponseDto<LoginResponse>> GoogleSignIn(GoogleSignInRequest googleSignInRequest);
        Task<ResponseDto<SignUpResponse>> SignUp(SignUpRequest signUpRequest);
        Task<ResponseDto<UserInfo>> GetUserInforByToken(string token);
        Task<ResponseDto<UserList>> GetUserList(string fullName, string email, string phoneNumber, string address, int role, int pageNumber, int pageSize);
        Task<ResponseDto<RoleList>> GetRoleList();
        Task<ResponseDto<UpdateUserResponse>> UpdateUser(UpdateUserRequest request, IFormFile imageFile);
        Task<ResponseDto<DeleteUserResponse>> DeleteUser(DeleteUserRequest request);
        Task<ResponseDto<GetUserResponse>> GetUserDetail(Guid id);
        Task<ResponseDto<GetVeterinarianResponse>> GetVeter(Guid id);
        Task<ResponseDto<UpdateUserResponse>> UpdateVeterinarianQualificationsAsync(GetVeterinarianRequest updatedProfile);
        Task<ResponseDto<AddMoney>> TopUpWallet(string token, decimal amount);
    }
}

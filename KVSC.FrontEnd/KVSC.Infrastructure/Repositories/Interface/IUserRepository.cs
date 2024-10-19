using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.DeleteUser;
using KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.DTOs.User.UpdateUser;

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
        Task<ResponseDto<UpdateUserResponse>> UpdateUser(UpdateUserRequest request);
        Task<ResponseDto<DeleteUserResponse>> DeleteUser(DeleteUserRequest request);
    }
}

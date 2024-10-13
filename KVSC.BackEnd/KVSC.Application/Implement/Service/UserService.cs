using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.KVSC.Application.Implement.Service
{
    public class UserService : IUserService
    {
        private readonly UnitOfWork _unitOfWork;
        public UserService(UnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        
        }

        public async Task<Result> GetUserByEmail(string email)
        {
            var user = await _unitOfWork.UserRepository.GetByAsync("Email", email);
            if (user == null) 
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }
            var userInfor = new UserInfor
            {
                UserName = user.Username,
                Email = user.Email,
                Avatar = user.ProfilePictureUrl,
                RoleName = user.role switch
                {
                    1 => "Admin",
                    2 => "Manager",
                    3 => "Veterinarian",
                    4 => "Staff",
                    5 => "Customer",
                    _ => throw new InvalidOperationException("Unknown role.")
                }
            };
            
            return Result.SuccessWithObject(userInfor);
                
        }
    }
}

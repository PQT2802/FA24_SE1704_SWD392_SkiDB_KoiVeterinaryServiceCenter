using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Common.Message;
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
            var userInfor = await _unitOfWork.UserRepository.GetByAsync("Email", email);
            if (userInfor == null) 
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }
            return Result.SuccessWithObject(userInfor);
                
        }
    }
}

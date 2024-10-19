using KVSC.Application.KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.User
{
    public class UpdateUserValidator : UserValidator<UpdateUserRequest>
    {
        public UpdateUserValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddUserNameRules(request => request.FullName);
            AddEmailRules(request => request.Email);
            AddPhoneNumberRules(request => request.PhoneNumber);
        }
    }
}

using KVSC.Application.Common.Validator.Abstract;
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
    public class UpdateUserValidator : AdminValidator<UpdateUserRequest>
    {
        public UpdateUserValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddUserNamesRules(request => request.FullName);
            AddEmailUserRules(request => request.Email);
            AddPhoneNumberRules(request => request.PhoneNumber);
        }
    }
}

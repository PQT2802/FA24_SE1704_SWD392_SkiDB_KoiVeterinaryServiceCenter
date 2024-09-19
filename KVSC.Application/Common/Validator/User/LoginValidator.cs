using Azure.Core;
using FluentValidation;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Application.KVSC.Application.Common.Validator.Abstract;

namespace KVSC.Application.KVSC.Application.Common.Validator.User
{
    public class LoginValidator : UserValidator<LoginRequest>
    {
        public LoginValidator() 
        {
            AddEmailRules(request => request.Email);

        }

    }
}

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
            RuleFor(request => request.Password)
           .NotEmpty().WithMessage("Password is required")
           .MinimumLength(8).WithMessage("Password must be at least 8 characters long")
           .Matches(@"^[A-Z].*").WithMessage("Password must start with a strong character (uppercase letter)")
           .Matches(@"[!@#$%^&*(),.?""{}|<>]").WithMessage("Password must contain at least one special character");
        }


    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.KVSC.Application.Common.Validator.Abstract
{
    public abstract class UserValidator<T> : AbstractValidator<T>
    {
        // Shared validation for UserName (with strong typing)
        protected void AddUserNameRules(Expression<Func<T, string>> userNameExpression)
        {
            RuleFor(userNameExpression)
                .NotEmpty().WithMessage("User name is required.")
                .MinimumLength(3).WithMessage("User name must be at least 3 characters.");
        }

        // Shared validation for Email (with strong typing)
        protected void AddEmailRules(Expression<Func<T, string>> emailExpression)
        {
            RuleFor(emailExpression)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");
        }
    }
}

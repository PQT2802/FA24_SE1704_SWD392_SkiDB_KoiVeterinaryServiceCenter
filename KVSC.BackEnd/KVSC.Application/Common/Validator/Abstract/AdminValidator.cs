using FluentValidation;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Abstract
{
    public class AdminValidator <T> : AbstractValidator<T>
    {
        private readonly UnitOfWork _unitOfWork;
        public AdminValidator(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        protected void AddUserNamesRules(Expression<Func<T, string>> fullNameSelector)
        {
            RuleFor(fullNameSelector)
                .NotEmpty().WithState(_ => UserErrorMessage.FieldIsEmpty("Username"))
                .MinimumLength(3).WithState(_ => UserErrorMessage.UserNameInValidLength());
        }

        protected void AddEmailUserRules(Expression<Func<T, string>> emailSelector)
        {
            RuleFor(emailSelector)
                .NotEmpty().WithState(_ => UserErrorMessage.FieldIsEmpty("Email"))
                .EmailAddress().WithState(_ => UserErrorMessage.EmailInValidFormat());
        }

        protected void AddPhoneNumberRules(Expression<Func<T, string>> phoneNumberSelector)
        {
            RuleFor(phoneNumberSelector)
                .Matches(@"^\d{10,11}$").WithState(_ => UserErrorMessage.PhoneInvalidFormat());
        }
        protected void AddPasswordRules(Expression<Func<T, string>> passwordFunc)
        {
            RuleFor(passwordFunc)
                .NotEmpty().WithState(_ => UserErrorMessage.FieldIsEmpty("Password"))
                .MinimumLength(8).WithState(_ => UserErrorMessage.PasswordInValidLength())
                .Matches(@"^[A-Z].*").WithState(_ => UserErrorMessage.PasswordInValidUppercase())
                .Matches(@"[!@#$%^&*(),.?""{}|<>]").WithState(_ => UserErrorMessage.PasswordInValidSpecialChar());
        }
    }
}

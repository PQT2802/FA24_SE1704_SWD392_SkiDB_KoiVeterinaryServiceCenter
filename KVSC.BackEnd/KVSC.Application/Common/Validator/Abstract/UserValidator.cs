using FluentValidation;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Linq.Expressions;

namespace KVSC.Application.KVSC.Application.Common.Validator.Abstract
{
    public abstract class UserValidator<T> : AbstractValidator<T>
    {
        private readonly UnitOfWork _unitOfWork;
        public UserValidator(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Validation for UserName (with option to check existence)
        protected void AddUserNameRules(Expression<Func<T, string>> userNameExpression, bool checkExists = false)
        {
            RuleFor(userNameExpression)
                .NotEmpty().WithState(_ => (UserErrorMessage.FieldIsEmpty("User name")))                
                .MinimumLength(3).WithState(_ => UserErrorMessage.UserNameInValidLength());

            // Check if username exists only if required (for registration)
            if (checkExists)
            {
                RuleFor(userNameExpression)
                    .MustAsync(async (userName, cancellation) =>
                        !(await _unitOfWork.UserRepository.UserNameExistsAsync(userName)))
                    .WithState(_ => UserErrorMessage.UserNameIsExist());
            }
        }
        protected void AddFullNameRules(Expression<Func<T, string>> fullNameExpression)
        {
            RuleFor(fullNameExpression)
                .NotEmpty().WithState(_ => (UserErrorMessage.FieldIsEmpty("fullName")));                
        }

        // Validation for Email (with option to check existence)
        protected void AddEmailRules(Expression<Func<T, string>> emailExpression, bool checkExists = false)
        {
            RuleFor(emailExpression)
                .NotEmpty().WithState(_ => UserErrorMessage.FieldIsEmpty("Email"))
                .EmailAddress().WithState(_ => UserErrorMessage.EmailInValidFormat());

            // Check if email exists only if required (for registration)
            if (checkExists)
            {
                RuleFor(emailExpression)
                    .MustAsync(async (email, cancellation) =>
                        !(await _unitOfWork.UserRepository.EmailExistsAsync(email)))
                    .WithState(_ => UserErrorMessage.EmailIsExist());
            }
        }

        // Shared validation for Password
        protected void AddPasswordRules(Expression<Func<T, string>> passwordFunc)
        {
            RuleFor(passwordFunc)
                .NotEmpty().WithState(_ => UserErrorMessage.FieldIsEmpty("Password"))
                .MinimumLength(8).WithState(_ => UserErrorMessage.PasswordInValidLength())
                .Matches(@"^[A-Z].*").WithState(_ => UserErrorMessage.PasswordInValidUppercase())
                .Matches(@"[!@#$%^&*(),.?""{}|<>]").WithState(_ => UserErrorMessage.PasswordInValidSpecialChar());
        }
        protected void AddPhoneNumberRules(Expression<Func<T, string>> phoneNumberSelector)
        {
            RuleFor(phoneNumberSelector)
                .Matches(@"^\d{10,11}$").WithState(_ => UserErrorMessage.PhoneInvalidFormat());
        }
        protected void AddAddressRules(Expression<Func<T, string>> addressExpression)
        {
            RuleFor(addressExpression)
                .NotEmpty().WithState(_ => (UserErrorMessage.FieldIsEmpty("address")));
        }
        protected void AddBirthdayRules(Expression<Func<T, DateTime>> birthdaySelector)
        {
            RuleFor(birthdaySelector)
                .NotEmpty().WithState(_ => UserErrorMessage.FieldIsEmpty("Date of Birth"))
                .Must(BeAtLeast18YearsOld).WithState(_ => UserErrorMessage.UserMustBeAtLeast18())
                .Must(NotBeInFuture).WithState(_ => UserErrorMessage.BirthdayCannotBeInFuture());
        }
        private bool BeAtLeast18YearsOld(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age >= 18;
        }
        private bool NotBeInFuture(DateTime dateOfBirth)
        {
            return dateOfBirth.Date <= DateTime.Today;
        }
    }
}

using FluentValidation;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Abstract
{
    public class VeterinarianValidator<T> : AbstractValidator<T>
    {
        private readonly IUnitOfWork _unitOfWork;

        public VeterinarianValidator(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected void AddLicenseNumberRules(Expression<Func<T, string>> licenseNumberSelector)
        {
            RuleFor(licenseNumberSelector)
                .NotEmpty().WithState(_ => UserErrorMessage.FieldIsEmpty("License Number"))
                .Matches(@"^[A-Z]{2}\d{6}$").WithState(_ => UserErrorMessage.LicenseNumberInvalidFormat()); // Ví dụ định dạng
        }

        protected void AddSpecialtyRules(Expression<Func<T, string>> specialtySelector)
        {
            RuleFor(specialtySelector)
                .NotEmpty().WithState(_ => UserErrorMessage.FieldIsEmpty("Specialty"))
                .MinimumLength(3).WithState(_ => UserErrorMessage.SpecialtyInvalidLength());
        }

        protected void AddQualificationsRules(Expression<Func<T, string>> qualificationsSelector)
        {
            RuleFor(qualificationsSelector)
                .NotEmpty().WithState(_ => UserErrorMessage.FieldIsEmpty("Qualifications"))
                .MinimumLength(5).WithState(_ => UserErrorMessage.QualificationsInvalidLength());
        }
    }
}

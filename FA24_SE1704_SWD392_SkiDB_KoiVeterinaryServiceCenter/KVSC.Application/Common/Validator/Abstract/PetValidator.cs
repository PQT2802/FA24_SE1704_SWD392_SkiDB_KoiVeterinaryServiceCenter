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
    public abstract class PetValidator<T> : AbstractValidator<T>
    {
        private readonly UnitOfWork _unitOfWork;
        public PetValidator(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected void AddPetNameRules(Expression<Func<T, string>> petNameExpression)
        {
            RuleFor(petNameExpression)
                .NotEmpty().WithState(_ => (PetErrorMessage.FieldIsEmpty("Pet name")))
                .Length(1, 50).WithState(_ => PetErrorMessage.FieldLength("Pet name", 1, 50));
        }

        protected void AddPetAgeRules(Expression<Func<T, int>> petAgeExpression)
        {
            RuleFor(petAgeExpression)
                .GreaterThan(0).WithState(_ => PetErrorMessage.FieldMustBePositive("Pet age"));
        }

        protected void AddPetBreedRules(Expression<Func<T, string>> petBreedExpression)
        {
            RuleFor(petBreedExpression)
                .NotEmpty().WithState(_ => PetErrorMessage.FieldIsEmpty("Pet breed"));
        }
    }
}

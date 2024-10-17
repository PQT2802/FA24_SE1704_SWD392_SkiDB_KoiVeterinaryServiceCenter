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

        //Pet 
        protected void AddPetNameRules(Expression<Func<T, string>> petNameExpression)
        {
            RuleFor(petNameExpression)
                .Length(1, 50).WithState(_ => PetErrorMessage.FieldLength("Pet name", 1, 50));
        }

        protected void AddPetAgeRules(Expression<Func<T, int>> petAgeExpression)
        {
            RuleFor(petAgeExpression)
                .GreaterThan(0).WithState(_ => PetErrorMessage.FieldMustBePositive("Pet age"));
        }

        protected void AddPetLengthRules(Expression<Func<T, double>> petLengthExpression)
        {
            RuleFor(petLengthExpression)
                .GreaterThan(0).WithState(_ => PetErrorMessage.FieldMustBePositive("Pet length"));
        }

        protected void AddPetWeightRules(Expression<Func<T, double>> petWeightExpression)
        {
            RuleFor(petWeightExpression)
                .GreaterThan(0).WithState(_ => PetErrorMessage.FieldMustBePositive("Pet weight"));
        }

        protected void AddPetQuantityRules(Expression<Func<T, int>> petQuantityExpression)
        {
            RuleFor(petQuantityExpression)
                .NotNull().WithState(_ => PetErrorMessage.FieldIsEmpty("Quantity"))
                .GreaterThan(0).WithState(_ => PetErrorMessage.FieldMustBePositive("Quantity"));
        }

        //Pet type
        protected void AddPetTypeGeneralRules(Expression<Func<T, string>> generalTypeExpression)
        {
            RuleFor(generalTypeExpression)
                .NotEmpty().WithState(_ => PetErrorMessage.FieldIsEmpty("General type"))
                .Length(1, 50).WithState(_ => PetErrorMessage.FieldLength("General type", 1, 50));
        }

        protected void AddPetTypeSpecificRules(Expression<Func<T, string>> specificTypeExpression)
        {
            RuleFor(specificTypeExpression)
                .NotEmpty().WithState(_ => PetErrorMessage.FieldIsEmpty("Specific type"))
                .Length(1, 100).WithState(_ => PetErrorMessage.FieldLength("Specific type", 1, 100));
        }

        //Pet habitat
        protected void AddPetHabitatTypeRules(Expression<Func<T, string>> habitatTypeExpression)
        {
            RuleFor(habitatTypeExpression)
                .NotEmpty().WithState(_ => PetErrorMessage.FieldIsEmpty("Habitat type"))
                .Length(1, 50).WithState(_ => PetErrorMessage.FieldLength("Habitat type", 1, 50));
        }
    }
}

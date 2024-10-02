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
    public class PetServiceValidator<T> : AbstractValidator<T>
    {
        private readonly UnitOfWork _unitOfWork;
        public PetServiceValidator(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        protected void AddPetServiceNameRules(Expression<Func<T, string>> petServiceNameExpression)
        {
            RuleFor(petServiceNameExpression)
                .NotEmpty().WithState(_ => (PetServiceErrorMessage.FieldIsEmpty("PetService name")));
        }
        protected void AddBasePriceRules(Expression<Func<T, decimal>> basePriceExpression)
        {
            RuleFor(basePriceExpression)
                .GreaterThan(0).WithState(_ => (PetServiceErrorMessage.InvalidFieldValue("BasePrice")));
        }
        protected void AddDurationRules(Expression<Func<T, string>> durationExpression)
        {
            RuleFor(durationExpression)
                .NotEmpty().WithState(_ => (PetServiceErrorMessage.FieldIsEmpty("Duration")));
        }
        protected void AddStaffQuantityRules(Expression<Func<T, int>> staffQuantityExpression)
        {
            RuleFor(staffQuantityExpression)
                .GreaterThan(0).WithState(_ => (PetServiceErrorMessage.InvalidFieldValue("StaffQuantity")));
        }
        protected void AddDateRangeRules(Expression<Func<T, DateTime>> availableFromExpression, Expression<Func<T, DateTime>> availableToExpression)
        {
            RuleFor(availableFromExpression)
                .LessThanOrEqualTo(availableToExpression)
                .WithState(_ => (PetServiceErrorMessage.InvalidFieldValue("AvailableFrom and AvailableTo")));
        }
        protected void AddTravelCostRangeRules(Expression<Func<T, decimal>> TravelCostExpression)
        {
            RuleFor(TravelCostExpression)
                .GreaterThanOrEqualTo(0).WithState(_ => (PetServiceErrorMessage.InvalidFieldValue("TravelCost")));
        }
    }
}

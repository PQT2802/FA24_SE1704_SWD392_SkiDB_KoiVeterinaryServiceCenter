using FluentValidation;
using KVSC.Infrastructure.DTOs.Pet.AddPet; // Ensure the namespace is correct
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using KVSC.Application.Common.Validator.Abstract;
using Azure.Core;

namespace KVSC.Application.Common.Validator.PetService
{
    public class AddPetServiceValidator : PetServiceValidator<AddPetServiceDTO>
    {
        //public AddPetServiceValidator() 
        //{
        //    RuleFor(service => service.BasePrice)
        //        .GreaterThan(0).WithState(_ => PetErrorMessage.FieldIsEmpty("Base Price"));

        //    RuleFor(service => service.Duration)
        //        .NotEmpty().WithState(_ => PetErrorMessage.FieldIsEmpty("Duration"));

        //    RuleFor(service => service.ImageUrl)
        //        .NotEmpty().WithState(_ => PetErrorMessage.FieldIsEmpty("Image URL"));

        //    RuleFor(service => service.StaffQuantity)
        //        .GreaterThan(0).WithState(_ => PetErrorMessage.FieldIsEmpty("Staff Quantity"));

        //    RuleFor(service => service.AvailableFrom)
        //        .LessThan(DateTime.UtcNow.AddDays(1)).WithState(_ => PetErrorMessage.FieldIsEmpty("Available From"));

        //    RuleFor(service => service.AvailableTo)
        //        .GreaterThan(service => service.AvailableFrom).WithState(_ => PetErrorMessage.FieldIsEmpty("Available To must be greater than Available From"));

        //    RuleFor(service => service.TravelCost)
        //        .GreaterThanOrEqualTo(0).WithState(_ => PetErrorMessage.FieldIsEmpty("Travel Cost"));
        //}
        public AddPetServiceValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddPetServiceNameRules(request => request.Name);
            AddBasePriceRules(request => request.BasePrice);
            AddDurationRules(request => request.Duration);
            AddStaffQuantityRules(request => request.StaffQuantity);
            AddTravelCostRangeRules(request => request.TravelCost);
            AddDateRangeRules(request => request.AvailableFrom, request => request.AvailableTo);
        }
    }
}
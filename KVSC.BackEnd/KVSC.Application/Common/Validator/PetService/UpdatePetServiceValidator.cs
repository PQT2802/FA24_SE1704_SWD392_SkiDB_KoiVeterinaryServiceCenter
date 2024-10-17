using Azure.Core;
using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.PetService.UpdatePetService;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.PetService
{
    public class UpdatePetServiceValidator : PetServiceValidator<UpdatePetServiceRequest>
    {
        public UpdatePetServiceValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddPetServiceNameRules(request => request.Name);
            AddBasePriceRules(request => request.BasePrice);
            AddDurationRules(request => request.Duration);
            AddTravelCostRangeRules(request => request.TravelCost);
            AddDateRangeRules(request => request.AvailableFrom, request => request.AvailableTo);
        }
    }
}

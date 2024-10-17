using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Pet
{
    public class UpdatePetvalidator : PetValidator<UpdatePetRequest>
    {
        public UpdatePetvalidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddPetNameRules(request => request.Name);
            AddPetAgeRules(request => request.Age.HasValue ? request.Age.Value : 0);
            AddPetLengthRules(request => request.Length.HasValue ? request.Length.Value : 0);
            AddPetWeightRules(request => request.Weight.HasValue ? request.Weight.Value : 0);
            AddPetQuantityRules(request => request.Quantity);
        }
    }
}

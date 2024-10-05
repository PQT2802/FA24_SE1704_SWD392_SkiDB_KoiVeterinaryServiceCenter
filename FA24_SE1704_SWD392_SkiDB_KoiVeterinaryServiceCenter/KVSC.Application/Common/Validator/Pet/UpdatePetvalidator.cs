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
            AddPetAgeRules(request => request.Age);
            AddPetGenderRules(request => request.Gender);
            AddPetLengthRules(request => request.Length);
            AddPetWeightRules(request => request.Weight);
        }
    }
}

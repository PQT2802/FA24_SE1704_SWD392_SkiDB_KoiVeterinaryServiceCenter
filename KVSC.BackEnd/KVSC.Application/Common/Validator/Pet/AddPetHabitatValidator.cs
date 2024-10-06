using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Pet.AddPetHabitat;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Pet
{
    public class AddPetHabitatValidator : PetValidator<AddPetHabitatRequest> 
    {
        public AddPetHabitatValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddPetHabitatTypeRules(request => request.HabitatType);
        }
    }
}

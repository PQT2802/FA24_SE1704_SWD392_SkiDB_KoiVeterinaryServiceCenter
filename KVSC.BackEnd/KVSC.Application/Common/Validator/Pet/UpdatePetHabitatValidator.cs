using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Pet.UpdatePetHabitat;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Pet
{
    public class UpdatePetHabitatValidator : PetValidator<UpdatePetHabitatRequest>
    {
        public UpdatePetHabitatValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddPetHabitatTypeRules(request => request.HabitatType);
        }
    }
}

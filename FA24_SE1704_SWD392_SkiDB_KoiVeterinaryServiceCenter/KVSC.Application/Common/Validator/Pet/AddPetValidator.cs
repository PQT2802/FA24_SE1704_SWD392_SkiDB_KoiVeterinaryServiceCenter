using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Pet
{
    public class AddPetValidator : PetValidator<AddPetRequest>
    {
            public AddPetValidator(UnitOfWork unitOfWork) : base(unitOfWork)
            {
                AddPetNameRules(request => request.PetName);
            }

    }
}

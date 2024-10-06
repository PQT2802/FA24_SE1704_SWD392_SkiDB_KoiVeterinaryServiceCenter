using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Pet.UpdatePetType;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Pet
{
    public class UpdatePetTypeValidator : PetValidator<UpdatePetTypeRequest>
    {
        public UpdatePetTypeValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddPetTypeGeneralRules(request => request.GeneralType);
            AddPetTypeSpecificRules(request => request.SpecificType);
        }

    }
}

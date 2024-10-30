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
            AddPetNameRules(request => request.Name!);
            AddPetAgeRules(request => request.Age ?? 0);
            AddPetGenderRules(request => request.Gender!);
            AddPetImageUrlRules(request => request.ImageUrl);
            AddPetColorRules(request => request.Color!);
            AddPetLengthRules(request => request.Length ?? 0);
            AddPetWeightRules(request => request.Weight ?? 0);
            AddPetQuantityRules(request => request.Quantity);
            AddPetLastHealthCheckRules(request => request.LastHealthCheck);
            AddPetNoteRules(request => request.Note!);
            AddPetHealthStatusRules(request => request.HealthStatus ?? 0);
        }
    }
}

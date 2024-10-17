﻿using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.PetServiceCategory.AddPetServiceCategroy;
using KVSC.Infrastructure.DTOs.PetServiceCategory.UpdatePetServiceCategory;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.PetServiceCategory
{
    public class UpdatePetServiceCategoryValidator : PetServiceCategoryValidator<UpdatePetServiceCategoryRequest>
    {
        public UpdatePetServiceCategoryValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddCategoryNameRules(request => request.Name);
            AddDescriptionRules(request => request.Description);
            AddServiceTypeRules(request => request.ServiceType);
            AddApplicableToRules(request => request.ApplicableTo);
        }
    }
}

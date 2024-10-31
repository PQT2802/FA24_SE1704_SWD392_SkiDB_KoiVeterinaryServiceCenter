using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.User
{
     public class UpdateVeterinarianValidator : VeterinarianValidator<UpdateVeterinarianRequest>
     {
         public UpdateVeterinarianValidator(UnitOfWork unitOfWork) : base(unitOfWork)
         {
            AddLicenseNumberRules(request => request.LicenseNumber);
            AddSpecialtyRules(request => request.Specialty);
            AddQualificationsRules(request => request.Qualifications);
        }
     }
}

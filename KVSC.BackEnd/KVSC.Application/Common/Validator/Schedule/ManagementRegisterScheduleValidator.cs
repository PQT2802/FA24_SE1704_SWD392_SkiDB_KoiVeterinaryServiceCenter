using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Schedule
{
    public class ManagementRegisterScheduleValidator : VeterinarianScheduleValidator<ManagementRegisterScheduleRequest>
    {
        public ManagementRegisterScheduleValidator()
        {
            // Apply the date validation rules
            AddDateRules(request => request.Date);

            // Apply the time range validation rules (StartTime must be less than EndTime)
            AddTimeRangeRules(request => request.StartTime, request => request.EndTime);
        }
    }
}

using FluentValidation;
using KVSC.Infrastructure.DTOs.Schedule;
using KVSC.Application.Common.Validator.Abstract;

namespace KVSC.Application.Common.Validator.VeterinarianSchedule
{
    public class RegisterScheduleValidator : VeterinarianScheduleValidator<RegisterScheduleRequest>
    {
        public RegisterScheduleValidator()
        {
            // Apply the date validation rules
            AddDateRules(request => request.Date);

            // Apply the time range validation rules (StartTime must be less than EndTime)
            AddTimeRangeRules(request => request.StartTime, request => request.EndTime);
        }
    }
}

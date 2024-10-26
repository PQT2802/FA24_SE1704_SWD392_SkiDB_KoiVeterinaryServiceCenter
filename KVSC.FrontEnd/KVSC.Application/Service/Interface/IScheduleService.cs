using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.VeterinarianSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Interface
{
    public interface IScheduleService
    {
        Task<ResponseDto<bool>> RegisterShiftAsync(RegisterShiftRequest request, string token);
        Task<ResponseDto<ScheduleDto>> GetWeeklyScheduleAsync(DateTime currentDay, string token);
    }
}

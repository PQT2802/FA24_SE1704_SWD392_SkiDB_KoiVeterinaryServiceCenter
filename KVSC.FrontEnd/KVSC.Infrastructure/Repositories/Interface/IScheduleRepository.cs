using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.VeterinarianSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Repositories.Interface
{
    public interface IScheduleRepository
    {
        Task<ResponseDto<bool>> RegisterShift(RegisterShiftRequest request, string token);
        Task<ResponseDto<ScheduleDto>> GetWeeklySchedule(DateTime currentDay, string token);
    }
}

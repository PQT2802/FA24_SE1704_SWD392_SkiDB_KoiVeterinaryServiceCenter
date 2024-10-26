using KVSC.Infrastructure.DTOs.VeterinarianSchedule;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.Repositories.Interface;
using KVSC.Application.Service.Interface;

namespace KVSC.Application.Service.Implement
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        public async Task<ResponseDto<bool>> RegisterShiftAsync(RegisterShiftRequest request, string token)
        {
            request.StartTime = request.StartTime ?? string.Empty;
            request.EndTime = request.EndTime ?? string.Empty;

            var response = await _scheduleRepository.RegisterShift(request, token);
            return response;
        }

        public async Task<ResponseDto<ScheduleDto>> GetWeeklyScheduleAsync(DateTime currentDay, string token)
        {
            return await _scheduleRepository.GetWeeklySchedule(currentDay, token);
        }
    }
}

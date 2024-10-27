using KVSC.Infrastructure.DTOs.VeterinarianSchedule;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.Repositories.Interface;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.Repositories.Implement;

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
        public async Task<ResponseDto<UserList>> GetVeterList()
        {
            return await _scheduleRepository.GetVeterList();
        }
        public async Task<ResponseDto<bool>> ManagementRegisterShiftAsync(ManagementRegisterShiftRequest request)
        {
            request.StartTime = request.StartTime ?? string.Empty;
            request.EndTime = request.EndTime ?? string.Empty;

            var response = await _scheduleRepository.ManagementRegisterShift(request);
            return response;
        }

        public async Task<ResponseDto<DeleteShiftResponse>> DeleteShiftAsync(DeleteShiftRequest request)
        {
            request.StartTime = request.StartTime ?? string.Empty;
            request.EndTime = request.EndTime ?? string.Empty;
            var response = await _scheduleRepository.DeleteShiftAsync(request);
            return response;
        }
        public async Task<ResponseDto<ScheduleDto>> GetWeeklyScheduleAsync(DateTime currentDay, string token)
        {
            return await _scheduleRepository.GetWeeklySchedule(currentDay, token);
        }
    }
}

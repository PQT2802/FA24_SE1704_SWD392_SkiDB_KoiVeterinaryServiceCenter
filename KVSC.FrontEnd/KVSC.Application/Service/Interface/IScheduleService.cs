using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
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
        Task<ResponseDto<UserList>> GetVeterList();
        Task<ResponseDto<bool>> ManagementRegisterShiftAsync(ManagementRegisterShiftRequest request);
        Task<ResponseDto<DeleteShiftResponse>> DeleteShiftAsync(DeleteShiftRequest request);
        Task<ResponseDto<ScheduleDto>> GetWeeklyScheduleAsync(DateTime currentDay, string token);
        Task<ResponseDto<GetVetId>> GetAvailableVeterinariansByDateTime(DateTime selectedDate);
    }
}

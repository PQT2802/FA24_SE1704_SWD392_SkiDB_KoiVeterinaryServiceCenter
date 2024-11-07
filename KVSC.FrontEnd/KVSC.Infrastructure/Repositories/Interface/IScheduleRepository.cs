using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
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
        Task<ResponseDto<bool>> ManagementRegisterShift(ManagementRegisterShiftRequest request);
        Task<ResponseDto<DeleteShiftResponse>> DeleteShiftAsync(DeleteShiftRequest request);
        Task<ResponseDto<UserList>> GetVeterList();

        Task<ResponseDto<ScheduleDto>> GetWeeklySchedule(DateTime currentDay, string token);
        Task<ResponseDto<GetVetId>> GetAvailableVeterinariansByDateTime(string selectedDate, Guid serviceId);
    }
}

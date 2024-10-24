using KVSC.Infrastructure.DTOs.Schedule;
using KVSC.Application.KVSC.Application.Common.Result;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IVeterinarianScheduleService
    {
        Task<Result> RegisterAvailableTimeAsync(Guid veterinarianId, RegisterScheduleRequest request);
        Task<Result> GetWeeklyScheduleAsync(Guid veterinarianId, DateTime startOfWeek);
        Task<Result> UpdateScheduleAvailabilityAsync(Guid veterinarianId, DateTime appointmentDate, TimeSpan startTime, TimeSpan endTime);
    }
}


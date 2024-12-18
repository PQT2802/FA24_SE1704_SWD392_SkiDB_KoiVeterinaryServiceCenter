﻿using KVSC.Infrastructure.DTOs.Schedule;
using KVSC.Application.KVSC.Application.Common.Result;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KVSC.Domain.Entities;

namespace KVSC.Application.Interface.IService
{
    public interface IVeterinarianScheduleService
    {
        Task<Result> RegisterAvailableTimeAsync(Guid veterinarianId, RegisterScheduleRequest request);
        Task<Result> RegisterAvailableTimeAsync(ManagementRegisterScheduleRequest request);
        Task<Result> GetWeeklyScheduleAsync(Guid veterinarianId, DateTime startOfWeek);
        Task<Result> UpdateScheduleAvailabilityAsync(Guid veterinarianId, DateTime appointmentDate, TimeSpan startTime, TimeSpan endTime);

        Task<Result> GetAllVeterinariansWeeklyScheduleAsync(DateTime currentDay);

        Task<Result> GetAvailableVeterinariansForDateAsync(DateTime appointmentDate);
        Task<Result> GetAvailableVeterinariansForBookingAppointmentAsync(DateTime appointmentDate,Guid serivceId);
        Task<Result> GetAvailableVeterinariansForDateTimeAsync(DateTime selectedDate, TimeSpan startTime, TimeSpan endTime);

    }
}


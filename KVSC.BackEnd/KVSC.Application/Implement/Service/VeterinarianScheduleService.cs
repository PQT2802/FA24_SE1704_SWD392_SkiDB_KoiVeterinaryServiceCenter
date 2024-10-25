using FluentValidation;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Schedule;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class VeterinarianScheduleService : IVeterinarianScheduleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<RegisterScheduleRequest> _scheduleValidator;

        public VeterinarianScheduleService(IUnitOfWork unitOfWork, IValidator<RegisterScheduleRequest> scheduleValidator)
        {
            _unitOfWork = unitOfWork;
            _scheduleValidator = scheduleValidator;
        }

        // Register veterinarian's available time
        public async Task<Result> RegisterAvailableTimeAsync(Guid veterinarianId, RegisterScheduleRequest request)
        {
            // Validate the input
            var validationResult = await _scheduleValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            // Register the available schedule
            await _unitOfWork.VeterinarianScheduleRepository.RegisterAvailableTime(veterinarianId, request.Date, request.StartTime, request.EndTime);
            return Result.Success();
        }

        // Get weekly schedule for a veterinarian
        public async Task<Result> GetWeeklyScheduleAsync(Guid veterinarianId, DateTime currentDay)
        {
            // Xác định ngày CN đầu tuần và T7 cuối tuần
            var dayOfWeek = currentDay.DayOfWeek;
            DateTime startOfWeek = currentDay.AddDays(-((int)dayOfWeek)); // Chủ Nhật (CN)
            DateTime endOfWeek = startOfWeek.AddDays(6); // Thứ Bảy (T7)

            // Lấy lịch làm việc từ CN đến T7
            var schedules = await _unitOfWork.VeterinarianScheduleRepository.GetWeeklySchedule(veterinarianId, startOfWeek);
            if (schedules == null || !schedules.Any())
            {
                return Result.Failure(Error.NotFound("ScheduleNotFound", "No schedule found for the specified veterinarian."));
            }

            // Đóng gói kết quả theo từng ngày (CN, T2, ..., T7)
            var result = new Dictionary<string, List<ScheduleDto>>
            {
                { "CN", new List<ScheduleDto>() },
                { "T2", new List<ScheduleDto>() },
                { "T3", new List<ScheduleDto>() },
                { "T4", new List<ScheduleDto>() },
                { "T5", new List<ScheduleDto>() },
                { "T6", new List<ScheduleDto>() },
                { "T7", new List<ScheduleDto>() }
            };

            foreach (var schedule in schedules)
            {
                var scheduleDto = new ScheduleDto
                {
                    VeterinarianId = schedule.VeterinarianId,
                    VeterinarianName = schedule.Veterinarian?.User?.FullName ?? "N/A",
                    Date = schedule.Date,
                    StartTime = schedule.StartTime,
                    EndTime = schedule.EndTime,
                    IsAvailable = schedule.IsAvailable
                };

                switch (schedule.Date.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        result["CN"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Monday:
                        result["T2"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Tuesday:
                        result["T3"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Wednesday:
                        result["T4"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Thursday:
                        result["T5"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Friday:
                        result["T6"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Saturday:
                        result["T7"].Add(scheduleDto);
                        break;
                }
            }

            return Result.SuccessWithObject(result);
        }

        public async Task<Result> GetAllVeterinariansWeeklyScheduleAsync(DateTime currentDay)
        {
            // Calculate the start and end of the week
            var dayOfWeek = currentDay.DayOfWeek;
            DateTime startOfWeek = currentDay.AddDays(-((int)dayOfWeek)); // Sunday (CN)
            DateTime endOfWeek = startOfWeek.AddDays(6); // Saturday (T7)

            // Retrieve schedules for all veterinarians from Sunday to Saturday
            var schedules = await _unitOfWork.VeterinarianScheduleRepository.GetAllVeterinariansWeeklySchedule(startOfWeek);
            if (schedules == null || !schedules.Any())
            {
                return Result.Failure(Error.NotFound("ScheduleNotFound", "No schedule found for the specified week."));
            }

            // Group schedules by day and veterinarian, include the veterinarian's name
            var result = schedules
                .GroupBy(s => s.Date.DayOfWeek)
                .ToDictionary(
                    g => g.Key.ToString(),
                    g => g.Select(schedule => new ScheduleDto
                    {
                        VeterinarianId = schedule.VeterinarianId,
                        VeterinarianName = schedule.Veterinarian.User.FullName, // Adding the veterinarian's name
                        Date = schedule.Date,
                        StartTime = schedule.StartTime,
                        EndTime = schedule.EndTime,
                        IsAvailable = schedule.IsAvailable
                    }).ToList()
                );

            return Result.SuccessWithObject(result);
        }


        // Update the availability after an appointment
        public async Task<Result> UpdateScheduleAvailabilityAsync(Guid veterinarianId, DateTime appointmentDate, TimeSpan startTime, TimeSpan endTime)
        {
            await _unitOfWork.VeterinarianScheduleRepository.UpdateScheduleAvailability(veterinarianId, appointmentDate, startTime, endTime);
            return Result.Success();
        }
    }
}

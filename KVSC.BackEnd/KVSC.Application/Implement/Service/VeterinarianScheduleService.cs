using Azure.Core;
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
        private readonly IValidator<ManagementRegisterScheduleRequest> _managementScheduleValidator;

        public VeterinarianScheduleService(IUnitOfWork unitOfWork, IValidator<RegisterScheduleRequest> scheduleValidator, IValidator<ManagementRegisterScheduleRequest> managementScheduleValidator)
        {
            _unitOfWork = unitOfWork;
            _scheduleValidator = scheduleValidator;
            _managementScheduleValidator = managementScheduleValidator;
        }

        public async Task<Result> RegisterAvailableTimeAsync(Guid userId, RegisterScheduleRequest request)
        {
            // Retrieve VeterinarianId using the UserId
            var veterinarian = await _unitOfWork.VeterinarianScheduleRepository.GetVeterinarianByUserIdAsync(userId);
            if (veterinarian == null)
            {
                return Result.Failure(Error.NotFound("VeterinarianNotFound", "Veterinarian not found for the provided user."));
            }

            // Validate the input
            var validationResult = await _scheduleValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            // Register the available schedule using the VeterinarianId
            await _unitOfWork.VeterinarianScheduleRepository.RegisterAvailableTime(veterinarian.Id, request.Date, request.StartTime, request.EndTime);
            return Result.SuccessWithObject(new { Message = "RegisterAvailableTime" });
        }
        public async Task<Result> RegisterAvailableTimeAsync(ManagementRegisterScheduleRequest request)
        {
            var veterinarian = await _unitOfWork.VeterinarianScheduleRepository.GetVeterinarianByUserIdAsync(request.Id);
            if (veterinarian == null)
            {
                return Result.Failure(Error.NotFound("VeterinarianNotFound", "Veterinarian not found for the provided user."));
            }
            // Validate the input
            var validationResult = await _managementScheduleValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            // Register the available schedule using the provided VeterinarianId
            await _unitOfWork.VeterinarianScheduleRepository.RegisterAvailableTime(veterinarian.Id, request.Date, request.StartTime, request.EndTime);
            return Result.SuccessWithObject(new { Message = "Schedule registered successfully for Veterinarian "});
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
                { "Sunday", new List<ScheduleDto>() },
                { "Monday", new List<ScheduleDto>() },
                { "Tuesday", new List<ScheduleDto>() },
                { "Wednesday", new List<ScheduleDto>() },
                { "Thursday", new List<ScheduleDto>() },
                { "Friday", new List<ScheduleDto>() },
                { "Saturday", new List<ScheduleDto>() }
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
                        result["Sunday"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Monday:
                        result["Monday"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Tuesday:
                        result["Tuesday"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Wednesday:
                        result["Wednesday"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Thursday:
                        result["Thursday"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Friday:
                        result["T6"].Add(scheduleDto);
                        break;
                    case DayOfWeek.Saturday:
                        result["Saturday"].Add(scheduleDto);
                        break;
                }
            }

            return Result.SuccessWithObject(result);
        }

        //public async Task<Result> GetAllVeterinariansWeeklyScheduleAsync(DateTime currentDay) // chi lay duoc 1 tuan
        //{
        //    // Calculate the start and end of the week
        //    var dayOfWeek = currentDay.DayOfWeek;
        //    DateTime startOfWeek = currentDay.AddDays(-((int)dayOfWeek)); // Sunday (CN)
        //    DateTime endOfWeek = startOfWeek.AddDays(6); // Saturday (T7)

        //    // Retrieve schedules for all veterinarians from Sunday to Saturday
        //    var schedules = await _unitOfWork.VeterinarianScheduleRepository.GetAllVeterinariansWeeklySchedule(startOfWeek);
        //    if (schedules == null || !schedules.Any())
        //    {
        //        return Result.Failure(Error.NotFound("ScheduleNotFound", "No schedule found for the specified week."));
        //    }

        //    // Group schedules by day and veterinarian, include the veterinarian's name
        //    var result = schedules
        //        .GroupBy(s => s.Date.DayOfWeek)
        //        .ToDictionary(
        //            g => g.Key.ToString(),
        //            g => g.Select(schedule => new ScheduleDto
        //            {
        //                VeterinarianId = schedule.VeterinarianId,
        //                VeterinarianName = schedule.Veterinarian.User.FullName, // Adding the veterinarian's name
        //                Date = schedule.Date,
        //                StartTime = schedule.StartTime,
        //                EndTime = schedule.EndTime,
        //                IsAvailable = schedule.IsAvailable
        //            }).ToList()
        //        );

        //    return Result.SuccessWithObject(result);
        //}

        public async Task<Result> GetAllVeterinariansWeeklyScheduleAsync(DateTime currentDay) // lay dc 1 thang  Edit : hung
        {
            DateTime startOfPeriod = currentDay.AddMonths(-1).Date;

            // Tính ngày kết thúc là ngày cuối cùng của tháng tiếp theo
            DateTime endOfPeriod = currentDay.AddMonths(1).Date.AddDays(DateTime.DaysInMonth(currentDay.AddMonths(1).Year, currentDay.AddMonths(1).Month) - 1);

            // Lấy lịch cho tất cả các bác sĩ từ đầu tháng trước đến cuối tháng sau
            var schedules = await _unitOfWork.VeterinarianScheduleRepository.GetAllVeterinariansScheduleAsync(startOfPeriod, endOfPeriod);
            if (schedules == null || !schedules.Any())
            {
                return Result.Failure(Error.NotFound("ScheduleNotFound", "No schedule found for the specified period."));
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
        public async Task<Result> UpdateScheduleAvailabilityAsync(Guid UserId, DateTime appointmentDate, TimeSpan startTime, TimeSpan endTime)
        {
            var veterinarian = await _unitOfWork.VeterinarianScheduleRepository.GetVeterinarianByUserIdAsync(UserId);
            if (veterinarian == null)
            {
                return Result.Failure(Error.NotFound("VeterinarianNotFound", "Veterinarian not found for the provided user."));
            }
            await _unitOfWork.VeterinarianScheduleRepository.UpdateScheduleAvailability(veterinarian.Id, appointmentDate, startTime, endTime);
            return Result.SuccessWithObject(new { Message = "UpdateScheduleAvailability" });
        }
    }
}

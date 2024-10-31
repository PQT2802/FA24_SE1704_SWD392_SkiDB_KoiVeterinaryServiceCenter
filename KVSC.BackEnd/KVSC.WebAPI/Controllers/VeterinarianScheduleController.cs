using KVSC.Application.Common;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.DTOs.Schedule;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace KVSC.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeterinarianScheduleController : ControllerBase
    {
        private readonly IVeterinarianScheduleService _veterinarianScheduleService;

        public VeterinarianScheduleController(IVeterinarianScheduleService veterinarianScheduleService)
        {
            _veterinarianScheduleService = veterinarianScheduleService;
        }

        // POST: api/veterinarian-schedule/register
        [HttpPost("register")]
        [Authorize]
        public async Task<IResult> RegisterAvailableTime([FromBody] RegisterScheduleRequest request)
        {
            CurrentUserObject currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);

            Result result = await _veterinarianScheduleService.RegisterAvailableTimeAsync(currentUser.UserId, request);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Schedule registered successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpPost("management/register")]
        public async Task<IResult> RegisterAvailableTime([FromBody] ManagementRegisterScheduleRequest request)
        {
            // Validate that the manager can perform this action
            // You might want to add role checking here if needed

            Result result = await _veterinarianScheduleService.RegisterAvailableTimeAsync(request);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Schedule registered successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/veterinarian-schedule/weekly
        [HttpGet("weekly")]
        [Authorize]
        public async Task<IResult> GetWeeklySchedule([FromQuery] DateTime currentDay)
        {
            CurrentUserObject currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            Result result = await _veterinarianScheduleService.GetWeeklyScheduleAsync(currentUser.UserId, currentDay);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Fetched weekly schedule successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        // PUT: api/veterinarian-schedule/update
        [HttpPut("update")]
        public async Task<IResult> UpdateScheduleAvailability([FromQuery] Guid UserId, [FromQuery] DateTime appointmentDate, [FromQuery] TimeSpan startTime, [FromQuery] TimeSpan endTime) // hung chinh sua cho manager
        {
            Result result = await _veterinarianScheduleService.UpdateScheduleAvailabilityAsync(UserId, appointmentDate, startTime, endTime);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Schedule availability updated successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }
        // POST: api/veterinarian-schedule/register
        [HttpPost("registerTest")]
        public async Task<IResult> RegisterAvailableTimeTest([FromBody] RegisterScheduleRequest request, [FromQuery] Guid? veterinarianId = null)
        {
            // Allow passing veterinarianId manually if provided, otherwise use TokenHelper
            var vetId = veterinarianId ?? (await TokenHelper.Instance.GetThisUserInfo(HttpContext)).UserId;

            Result result = await _veterinarianScheduleService.RegisterAvailableTimeAsync(vetId, request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Schedule registered successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/veterinarian-schedule/weekly
        [HttpGet("weeklyTest")]
        public async Task<IResult> GetWeeklyScheduleTest([FromQuery] DateTime currentDay, [FromQuery] Guid? veterinarianId = null)
        {
            // Allow passing veterinarianId manually if provided, otherwise use TokenHelper
            var vetId = veterinarianId ?? (await TokenHelper.Instance.GetThisUserInfo(HttpContext)).UserId;

            Result result = await _veterinarianScheduleService.GetWeeklyScheduleAsync(vetId, currentDay);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Fetched weekly schedule successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        // PUT: api/veterinarian-schedule/update
        [HttpPut("updateTest")]
        public async Task<IResult> UpdateScheduleAvailabilityTest([FromQuery] DateTime appointmentDate, [FromQuery] TimeSpan startTime, [FromQuery] TimeSpan endTime, [FromQuery] Guid? veterinarianId = null)
        {
            // Allow passing veterinarianId manually if provided, otherwise use TokenHelper
            var vetId = veterinarianId ?? (await TokenHelper.Instance.GetThisUserInfo(HttpContext)).UserId;

            Result result = await _veterinarianScheduleService.UpdateScheduleAvailabilityAsync(vetId, appointmentDate, startTime, endTime);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Schedule availability updated successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/veterinarian-schedule/schedule
        [HttpGet("schedule")]
        public async Task<IResult> GetScheduleTest([FromQuery] Guid? veterinarianId = null)
        {
            // Allow passing veterinarianId manually if provided, otherwise use TokenHelper
            var vetId = veterinarianId ?? (await TokenHelper.Instance.GetThisUserInfo(HttpContext)).UserId;

            Result result = await _veterinarianScheduleService.GetWeeklyScheduleAsync(vetId, DateTime.Now);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Fetched schedule successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/veterinarian-schedule/all-weekly
        [HttpGet("all-weekly")]
        public async Task<IResult> GetAllVeterinariansWeeklySchedule([FromQuery] DateTime currentDay)
        {
            Result result = await _veterinarianScheduleService.GetAllVeterinariansWeeklyScheduleAsync(currentDay);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Fetched all veterinarians' weekly schedule successfully.")
                : ResultExtensions.ToProblemDetails(result);    
        }
        // GET: api/veterinarian-schedule/available-vets
        [HttpGet("available-vets")]
        public async Task<IResult> GetAvailableVeterinariansByDateTime(
            [FromQuery] DateTime selectedDate,
            [FromQuery] TimeSpan? startTime = null,
            [FromQuery] TimeSpan? endTime = null)
        {
            // Set default values for startTime and endTime if null
            TimeSpan actualStartTime = startTime ?? TimeSpan.Zero; // Default to 00:00
            TimeSpan actualEndTime = endTime ?? new TimeSpan(23, 59, 59); // Default to 23:59

            Result result = await _veterinarianScheduleService.GetAvailableVeterinariansForDateTimeAsync(selectedDate, actualStartTime, actualEndTime);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Fetched available veterinarians successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }


    }
}

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
        [Authorize]
        public async Task<IResult> UpdateScheduleAvailability([FromQuery] DateTime appointmentDate, [FromQuery] TimeSpan startTime, [FromQuery] TimeSpan endTime)
        {
            CurrentUserObject currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            Result result = await _veterinarianScheduleService.UpdateScheduleAvailabilityAsync(currentUser.UserId, appointmentDate, startTime, endTime);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Schedule availability updated successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}

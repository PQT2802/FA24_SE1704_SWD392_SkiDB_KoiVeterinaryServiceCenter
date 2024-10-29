using KVSC.Application.Common;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using KVSC.Infrastructure.DTOs.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        // POST: api/appointment/service
        [HttpPost("service")]
        public async Task<IResult> MakeAppointmentForService([FromBody] MakeAppointmentForServiceRequest request)
        {
            Result result = await _appointmentService.MakeAppointmentForServiceAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Appointment for service created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // POST: api/appointment/combo
        [HttpPost("combo")]
        public async Task<IResult> MakeAppointmentForCombo([FromBody] MakeAppointmentForComboRequest request)
        {
            Result result = await _appointmentService.MakeAppointmentForComboAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Appointment for combo created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpGet("list")]
        public async Task<IResult> GetAppointmentListAsync()
        {
            Result result = await _appointmentService.GetAppointmentListAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Fetched appointment list successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/appointment/list/vet/
        [Authorize]
        [HttpGet("list/vet")]
        public async Task<IResult> GetAppointmentListByUserIdAsync()
        {
            CurrentUserObject c = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            Result result = await _appointmentService.GetAppointmentListByUserIdAsync(c.UserId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Fetched appointment list for the specified vet successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpPut("update")]
        public async Task<IResult> UpdateAppointmentStatusAsync(UpdateStatusRequest updateStatus)
        {
            Result result = await _appointmentService.UpdateAppointmentStatusAsync(updateStatus.AppointmentId, updateStatus.Status);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Update status successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }
        // GET: api/appointment/detail/{id}
        [HttpGet("detail/{appointmentId}")]
        public async Task<IResult> GetAppointmentDetailByIdAsync(Guid appointmentId)
        {
            Result result = await _appointmentService.GetAppointmentDetailByIdAsync(appointmentId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Fetched appointment detail successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

    }
}

using KVSC.Application.Common;
using KVSC.Application.Implement.Service;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Appointment.AssignVeterinarian;
using KVSC.Infrastructure.DTOs.Appointment.GetAppointment;
using KVSC.Infrastructure.DTOs.Appointment.GetAppointmentDetail;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IVeterinarianScheduleService _veterinarianScheduleService;

        public AppointmentController(IAppointmentService appointmentService, IVeterinarianScheduleService veterinarianScheduleService)
        {
            _appointmentService = appointmentService;
            _veterinarianScheduleService = veterinarianScheduleService;
        }

        // POST: api/appointment/service
        //[HttpPost("service")]
        //public async Task<IResult> MakeAppointmentForService([FromBody] MakeAppointmentForServiceRequest request)
        //{
        //    Result result = await _appointmentService.MakeAppointmentForServiceAsync(request);
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "Appointment for service created successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}
        // POST: api/appointment/service
        [HttpPost("service")]
        public async Task<IResult> MakeAppointmentForService([FromBody] MakeAppointmentForServiceRequest request)
        {
            Result result = await _appointmentService.MakeAppointmentForServiceAsyncNotAuto(request);
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

        // GET: api/appointment/list/customer/
        [Authorize]
        [HttpGet("list/customer")]
        public async Task<IResult> GetAppointmentListByCustomerIdAsync()
        {
            // Retrieve the current user's information from the token
            CurrentUserObject c = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
    
            // Call the service method for customer appointments
            Result result = await _appointmentService.GetAppointmentListByCustomerIdAsync(c.UserId);
    
            // Return appropriate response based on success or failure of the service call
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Fetched appointment list for the specified customer successfully.")
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
        // GET: api/appointment/unassigned
        [HttpGet("unassigned")]
        public async Task<IResult> GetUnassignedAppointmentsAsync()
        {
            Result result = await _appointmentService.GetUnassignedAppointmentsAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Fetched unassigned appointments successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/appointment/assign/{appointmentId}
        [HttpGet("assign/{appointmentId}")]
        public async Task<IResult> GetAppointmentWithAvailableVeterinariansAsync(Guid appointmentId)
        {
            // Use the new GetAppointmentByIdAsync method
            var appointmentResult = await _appointmentService.GetAppointmentByIdAsync(appointmentId);
            if (!appointmentResult.IsSuccess)
                return ResultExtensions.ToProblemDetails(appointmentResult);

            // Since GetAppointmentByIdAsync now returns an Appointment entity directly
            var appointment = appointmentResult.Object as GetAllAppointment;
            if (appointment == null)
                return Results.Problem("Appointment not found.", statusCode: 404);

              
            var availableVetsResult = await _veterinarianScheduleService.GetAvailableVeterinariansForDateAsync(appointment.AppointmentDate);

            return availableVetsResult.IsSuccess
                ? ResultExtensions.ToSuccessDetails(availableVetsResult, "Assigned veterinarian to appointment successfully.")
                : ResultExtensions.ToProblemDetails(availableVetsResult);
        }


        // PUT: api/appointment/assign-vet
        [HttpPut("assign-vet")]
        public async Task<IResult> AssignVeterinarianToAppointment([FromBody] AssignVeterinarianRequest request)
        {
            var result = await _appointmentService.AssignVeterinarianAsync(request.AppointmentId, request.VeterinarianId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Assigned veterinarian to appointment successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}

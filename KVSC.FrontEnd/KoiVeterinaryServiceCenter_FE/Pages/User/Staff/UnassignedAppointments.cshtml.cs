using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Appointment.AddAppointment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Staff
{
    public class UnassignedAppointmentsModel : PageModel
    {
        private readonly IAppointmentService _appointmentService;

        [BindProperty]
        public AppointmentList UnassignedAppointments { get; set; } = new();

        [BindProperty]
        public Guid AppointmentId { get; set; }

        public VeterinarianDto AvailableVeterinarians { get; set; } = new VeterinarianDto();
        public UnassignedAppointmentsModel(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            
            var result = await _appointmentService.GetUnassignedAppointmentsAsync();
            if (result.IsSuccess)
            {
                UnassignedAppointments = result.Data ?? new AppointmentList();

            }
            else
            {
                return RedirectToPage("/Errors/404");
            }
            return Page();
        }
        public async Task<IActionResult> OnGetVeterinariansAsync(Guid appointmentId)
        {
            var result = await _appointmentService.GetAvailableVeterinarians(appointmentId);
            if (result.IsSuccess)
            {
                return new JsonResult(result.Data);
            }
            return new JsonResult(new { Message = "Failed to load veterinarians" });
        }
        public async Task<IActionResult> OnPostAssignVeterinarianAsync(Guid appointmentId, Guid veterinarianId)
        {
            var request = new AssignVeterinarianRequest
            {
                AppointmentId = appointmentId,
                VeterinarianId = veterinarianId
            };
            var result = await _appointmentService.AssignVeterinarianToAppointment(request);

            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Assign veterinarian successful."; // Thông báo thành công
                return RedirectToPage("/user/staff/unassignedAppointments"); // Redirect thành công
            }

            TempData["ErrorMessage"] = "Assign veterinarian failed."; // Thông báo lỗi
            return RedirectToPage("/Errors/404"); // Redirect lỗi
        }

    }
}

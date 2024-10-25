using KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class AppointmentDetailModel : PageModel
    {
        private readonly IAppointmentService _appointmentService;

        // Constructor for dependency injection
        public AppointmentDetailModel(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        // Property to hold the appointment details
        [BindProperty]
        public GetAppointmentDetailResponse GetAppointmentDetailResponse { get; set; } = new GetAppointmentDetailResponse();

        public async Task<IActionResult> OnGetAsync(Guid appointmentId)
        {
            // Fetch the appointment details from the service using the appointmentId
            var result = await _appointmentService.GetAppointmentDetail(appointmentId);

            if (result.IsSuccess)
            {
                GetAppointmentDetailResponse = result.Data;
                return Page();
            }

            // If appointment is not found, return 404
            return NotFound();
        }
    }
}

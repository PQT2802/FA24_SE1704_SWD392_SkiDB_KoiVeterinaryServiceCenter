using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class AppointmentsModel : PageModel
    {
        private readonly IAppointmentService _appointmentsService;

        public AppointmentsModel(IAppointmentService appointmentsService)
        {
            _appointmentsService = appointmentsService;
        }

        [BindProperty]
        public List<AppointmentList> AppointmentList { get; set; } = default!;

        [BindProperty]
        public int AppointmentId { get; set; } // For handling appointment actions

        [BindProperty]
        public string ReportDetails { get; set; } = string.Empty; // For handling report submission

        public async Task OnGetAsync()
        {
            var result = await _appointmentsService.GetAppointmentListAsync();
            AppointmentList = result.Data;
        }

        //public async Task<IActionResult> OnPostAcceptAsync(int appointmentId)
        //{
        //    // Call service to accept appointment
        //    await _appointmentsService.UpdateStatusAsync(appointmentId, "Accepted");

        //    // Refresh the list after the action
        //    return RedirectToPage();
        //}

        //public async Task<IActionResult> OnPostRejectAsync(int appointmentId)
        //{
        //    // Call service to reject appointment
        //    await _appointmentsService.UpdateStatusAsync(appointmentId, "Rejected");

        //    // Refresh the list after the action
        //    return RedirectToPage();
        //}

        //public async Task<IActionResult> OnPostMarkInProgressAsync(int appointmentId)
        //{
        //    // Call service to mark appointment as in progress
        //    await _appointmentsService.UpdateStatusAsync(appointmentId, "InProgress");

        //    // Refresh the list after the action
        //    return RedirectToPage();
        //}

        //public async Task<IActionResult> OnPostSubmitReportAsync()
        //{
        //    // Submit report for the appointment
        //    await _appointmentsService.SubmitReportAsync(AppointmentId, ReportDetails);

        //    // Refresh the list after the report is submitted
        //    return RedirectToPage();
        //}
    }
}

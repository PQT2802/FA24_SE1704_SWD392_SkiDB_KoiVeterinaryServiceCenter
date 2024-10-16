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







        public async Task OnGetAsync()
        {
            var result = await _appointmentsService.GetAppointmentListAsync();

            AppointmentList = result.Data;
        }
    }
}

using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Product;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class AppointmentsModel : PageModel
    {
        private readonly IAppointmentService _appointmentsService;
        private readonly IProductService _productService;

        public AppointmentsModel(IAppointmentService appointmentsService, IProductService productService)
        {
            _appointmentsService = appointmentsService;
            _productService = productService;
        }

        [BindProperty]
        public AppointmentList AppointmentList { get; set; } = default!;
        [BindProperty]
        public GetMedicine GetMedicine { get; set; } = default!;
        [BindProperty]
        public AddServiceReportRequest AddServiceReport { get; set; } = new AddServiceReportRequest();

        public async Task OnGetAsync()
        {
            var token = HttpContext.Session.GetString("Token");
            var result = await _appointmentsService.GetAppoitmentListForVet(token);
            if (result.IsSuccess)
            {
                AppointmentList = result.Data;
                var medicine = await _productService.GetMedicines();
                GetMedicine = medicine.Data;
            }
        }
    
    }
}

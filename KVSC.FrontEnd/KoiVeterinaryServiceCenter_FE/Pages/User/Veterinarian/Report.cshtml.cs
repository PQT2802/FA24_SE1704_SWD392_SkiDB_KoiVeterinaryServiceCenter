using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;
using KVSC.Infrastructure.DTOs.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class ReportModel : PageModel
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IProductService _productService;

        public ReportModel(IAppointmentService appointmentService, IProductService productService)
        {
            _appointmentService = appointmentService;
            _productService = productService;
        }

        [BindProperty]
        public AddServiceReportRequest AddServiceReportRequest { get; set; } = new();

        public GetMedicine GetMedicines { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(Guid appointmentId)
        {
            AddServiceReportRequest.AppointmentId = appointmentId;

            var medicinesResult = await _productService.GetMedicines();
            if (medicinesResult.IsSuccess && medicinesResult.Data.Extensions?.Data != null)
            {
                GetMedicines = medicinesResult.Data;
            }
            else
            {
                GetMedicines.Extensions = new Extensions<List<GetMedicineData>> { Data = new List<GetMedicineData>() };
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Please ensure all fields are filled correctly.";
                return Page();
            }

            var result = await _appointmentService.AddServiceReport(AddServiceReportRequest);

            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Service report created successfully.";
                return RedirectToPage("/User/Veterinarian/AppointmentDetail", new { appointmentId = AddServiceReportRequest.AppointmentId });
            }

            ModelState.AddModelError(string.Empty, "Failed to create service report.");
            return Page();
        }
    }
}

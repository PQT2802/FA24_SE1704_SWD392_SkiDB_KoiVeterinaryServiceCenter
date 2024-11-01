using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail;
using KVSC.Infrastructure.DTOs.Product;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;
using KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class AppointmentDetailModel : PageModel
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IProductService _productService;
        

        // Constructor for dependency injection
        public AppointmentDetailModel(IAppointmentService appointmentService,IProductService productService)
        {
            _appointmentService = appointmentService;
            _productService = productService;
        }

        // Property to hold the appointment details
        [BindProperty]
        public GetAppointmentDetailResponse GetAppointmentDetailResponse { get; set; } = new();
        [BindProperty]
        public GetMedicine GetMedicines {  get; set; } = new();
        [BindProperty]
        public AddServiceReportRequest AddServiceReportRequest { get; set; } = new();
        
        public async Task<IActionResult> OnGetAsync(Guid appointmentId)
        {

            var appointmentResult = await _appointmentService.GetAppointmentDetail(appointmentId);
            var medicinesResult = await _productService.GetMedicines();
            
            if (appointmentResult.IsSuccess && appointmentResult.Data.Extensions?.Data != null)
            {
                GetAppointmentDetailResponse = appointmentResult.Data;
                AddServiceReportRequest.AppointmentId = appointmentId;

                // Ensure Extensions is not null and contains an empty Data list if the API call fails
                if (medicinesResult.IsSuccess && medicinesResult.Data.Extensions?.Data != null)
                {
                    GetMedicines = medicinesResult.Data;
                    Console.WriteLine($"GetMedicines Extensions Data Count: {GetMedicines.Extensions?.Data?.Count ?? 0}");
                }
                else
                {
                    GetMedicines.Extensions = new Extensions<List<GetMedicineData>> { Data = new List<GetMedicineData>() };
                }

                return Page();
            }
            GetAppointmentDetailResponse.Extensions = new Extensions<GetAppointmentDetailData> { Data = new GetAppointmentDetailData() };

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Ignore validation errors related to Extensions by clearing its errors
            


            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Please ensure all fields are filled correctly.";
                return RedirectToPage();
            }

            var result = await _appointmentService.AddServiceReport(AddServiceReportRequest);

            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Service report created successfully.";
                return RedirectToPage(new { appointmentId = AddServiceReportRequest.AppointmentId });
            }

            ModelState.AddModelError(string.Empty, "Failed to create service report.");
            return Page();
        }
    }
}

using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class AppointmentFormViewComponent : ViewComponent
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IPetServiceService _petServiceService;

        public AppointmentFormViewComponent(IPetServiceService petServiceService, IAppointmentService appointmentService)
        {
            _petServiceService = petServiceService;
            _appointmentService = appointmentService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Fetch necessary data for the form
            var petServiceResponse = await _petServiceService.GetKoiServiceList();

            var model = new AppointmentFormViewModel
            {
                Services = petServiceResponse.IsSuccess ? petServiceResponse.Data.Extensions?.Data : new List<Data>(),
                AppointmentDate = DateTime.Now, // Default date
            };

            return View(model); // This will render the view with the form
        }

        // Handle appointment submission
        [HttpPost]
        public async Task<IActionResult> SubmitAppointment([FromForm] AppointmentFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message = "Form validation failed." });
            }

            // Create the appointment request
            var request = new MakeAppointmentForServiceRequest
            {
                UserId = model.CustomerId,
                PetId = model.PetServiceId,
                ServiceId = model.PetServiceId,
                DateTime = model.AppointmentDate
            };

            var response = await _appointmentService.MakeAppointmentForServiceAsync(request);

            if (response.IsSuccess)
            {
                return Json(new { success = true, message = "Appointment successfully booked!" });
            }

            return Json(new { success = false, message = "Failed to book appointment.", errors = response.Errors });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using KVSC.Infrastructure.DTOs;
using System.Threading.Tasks;

[Route("appointment")]
public class AppointmentFormController : Controller
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentFormController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpPost("submit")]
    public async Task<IActionResult> SubmitAppointment(AppointmentFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            // Return to the form with validation errors
            return View("AppointmentForm", model); 
        }

        var request = new MakeAppointmentForServiceRequest
        {
            CustomerId = model.CustomerId,
            PetServiceId = model.PetServiceId,
            AppointmentDate = model.AppointmentDate
        };

        var response = await _appointmentService.MakeAppointmentForServiceAsync(request);

        if (response.IsSuccess)
        {
            ViewBag.Message = "Appointment created successfully!";
        }
        else
        {
            ViewBag.Error = "Failed to create appointment. Errors: " + string.Join(", ", response.Errors.Select(e => e.Description));
        }

        return View("AppointmentForm", model);  // Return the form view after processing
    }
}
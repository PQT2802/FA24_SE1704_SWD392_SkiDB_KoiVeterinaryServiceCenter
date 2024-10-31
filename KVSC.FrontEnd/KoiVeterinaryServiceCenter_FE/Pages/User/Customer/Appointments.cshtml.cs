using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Rating.AddRating;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Customer;

public class AppointmentsModel : PageModel
{
    private readonly IAppointmentService _appointmentService;

    private readonly IRatingService _ratingService;
    [BindProperty]
    public RatingCreateRequest RatingRequest { get; set; } = default!;
    public AppointmentsModel(IAppointmentService appointmentsService, IRatingService ratingService)
    {
        _appointmentService = appointmentsService;
        _ratingService = ratingService;
    }
    

    [BindProperty] public AppointmentList AppointmentList { get; set; } = default!;

    [BindProperty] public List<ErrorDetail> ErrorMessage { get; set; } = new List<ErrorDetail>();

    public async Task OnGetAsync()
    {
        var token = HttpContext.Session.GetString("Token");
        if (string.IsNullOrEmpty(token))
        {
            ErrorMessage.Add(new ErrorDetail { Code = "TokenError", Description = "Authorization token is missing or expired.", Type = "Authorization" });
            return;
        }

        var result = await _appointmentService.GetAppointmentListForCustomer(token);
        if (result.IsSuccess && result.Data != null)
        {
            AppointmentList = result.Data;
        }
        else
        {
            // If there's an error, add it to ErrorMessage to display on the Razor page
            ErrorMessage = result.Errors ?? new List<ErrorDetail>
            {
                new ErrorDetail { Code = "FetchError", Description = "Failed to retrieve appointments.", Type = "ServiceError" }
            };
        }
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var result = await _ratingService.CreateRatingAsync(RatingRequest);

        if (result.IsSuccess)
        {
            TempData["SuccessMessageRating"] = result.Message;
            return RedirectToPage();
        }
        else
        {
            TempData["ErrorMessageRating"] = result.Message;
            return RedirectToPage();
        }
    }
}
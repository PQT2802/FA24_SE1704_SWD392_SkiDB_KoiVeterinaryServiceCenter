using KVSC.Application.Service.Implement;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Rating.AddRating;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Customer;

public class AppointmentsModel : PageModel
{
    private readonly IAppointmentService _appointmentService;

    private readonly IRatingService _ratingService;
    private readonly IMessageService _messageService;
    
    [BindProperty]
    public RatingCreateRequest RatingRequest { get; set; } = default!;
    public AppointmentsModel(IAppointmentService appointmentsService, IRatingService ratingService, IMessageService messageService)
    {
        _appointmentService = appointmentsService;
        _ratingService = ratingService;
        _messageService = messageService;
    }
    public Guid CurrentUserId { get; set; }
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
    public async Task<IActionResult> OnGetConversationAsync(Guid customerId, Guid veterinarianId, Guid appointmentId)
    {
        var token = HttpContext.Session.GetString("Token");

        if (string.IsNullOrEmpty(token))
        {
            return RedirectToPage("/Account/SignIn");
        }

        // Giải mã token để lấy userId (người dùng hiện tại)
        var handler = new JwtSecurityTokenHandler();
        var jwtToken = handler.ReadJwtToken(token);
        var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;

        if (!Guid.TryParse(userIdClaimString, out Guid currentUserId))
        {
            ModelState.AddModelError(string.Empty, "Unable to decode userId from token..");
            return Page();
        }
        
        var result = await _messageService.GetMessages(customerId, veterinarianId, appointmentId);

        if (result.IsSuccess && result.Data != null)
        {

            return new JsonResult(new
            {
                isSuccess = true,
                data = result.Data.Extensions.Data,
                currentUserId = currentUserId
            });
        }
        else
        {
            return new JsonResult(new
            {
                isSuccess = false,
                message = "Failed to retrieve messages."
            });
        }
    }
}
using KVSC.Application.Service.Implement;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Message.AddMessage;
using KVSC.Infrastructure.DTOs.Product;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class AppointmentsModel : PageModel
    {
        private readonly IAppointmentService _appointmentsService;
        private readonly IProductService _productService;
        private readonly IMessageService _messageService;


        public AppointmentsModel(IAppointmentService appointmentsService, IProductService productService, IMessageService messageService)
        {
            _appointmentsService = appointmentsService;
            _productService = productService;
            _messageService = messageService;
        }

        [BindProperty]
        public CreateMessageRequest CreateMessageRequest { get; set; }

        [BindProperty]
        public AppointmentList AppointmentList { get; set; } = default!;
        [BindProperty]
        public AddServiceReportRequest AddServiceReport { get; set; } = new AddServiceReportRequest();
        [BindProperty]
        public List<ErrorDetail> ErrorMessage { get; set; } = new List<ErrorDetail>();
        public async Task OnGetAsync()
        {
            var token = HttpContext.Session.GetString("Token");
            var result = await _appointmentsService.GetAppoitmentListForVet(token);
            if (result.IsSuccess)
            {
                AppointmentList = result.Data;
            }
        }

        public async Task<IActionResult> OnPostUpdateStatusAsync(Guid appointmentId, string status)
        {

            // Call the service to update the status
            var response = await _appointmentsService.UpdateAppointmentStatusAsync(appointmentId, status);

            if (response.IsSuccess)
            {
                TempData["SuccessMessage"] = "Appointment status updated successfully.";
                return RedirectToPage(); // Optionally redirect to the same or another page
            }

            // If the update fails, return the current page with the error messages

            ErrorMessage = response.Errors;
            return Page(); // Return the page with validation errors, if any
        }

        //===========create message click======================================================
        public async Task<IActionResult> OnPostMessageAsync(Guid recipientId, string content)
        {
            var token = HttpContext.Session.GetString("Token");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var senderIdString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;

            if (!Guid.TryParse(senderIdString, out Guid senderId))
            {
                ModelState.AddModelError(string.Empty, "Invalid Sender ID.");
                return BadRequest("Invalid Sender ID.");
            }

            // Assuming you have a CreateMessageRequest object
            CreateMessageRequest.SenderId = senderId;
            CreateMessageRequest.RecipientId = recipientId; // Set recipientId here
            CreateMessageRequest.Content = content; // Set content here

            var result = await _messageService.SendMessage(CreateMessageRequest);
            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Message sent successfully!";
                return RedirectToPage(); // Redirect to the same page to show the message
            }

            TempData["ErrorMessage"] = "Unable to send message.";
            return RedirectToPage(); // Redirect to the same page to show the error
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
}

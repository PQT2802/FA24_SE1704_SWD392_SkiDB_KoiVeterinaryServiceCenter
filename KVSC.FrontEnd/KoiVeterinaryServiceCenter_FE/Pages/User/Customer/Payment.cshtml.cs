using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Customer
{
    public class PaymentModel : PageModel
    {
        public readonly IUserService _userService;
        public PaymentModel(IUserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public Payment Payment { get; set; } 
        public async Task OnGetAsync()
        {
            var token = HttpContext.Session.GetString("Token");
            var result = await _userService.GetPaymentOfUser(token);
            if (result.IsSuccess)
            {
                Payment = result.Data;
            }
        }
        public async Task<IActionResult> OnPostPayAppointmentAsync(Guid paymentId)
        {
            var token = HttpContext.Session.GetString("Token");

            // Call the service to complete the payment
            var result = await _userService.CompletePayment(token, paymentId);

            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Payment completed successfully.";
            }
            else
            {
                var errorDetail = result.Errors.FirstOrDefault(e => e.Code.Equals("Transaction"));
                if (errorDetail != null)
                {
                    TempData["ErrorMessage"] = errorDetail.Description.ToString();
                }
                else
                {
                    TempData["ErrorMessage"] = "Failed to pay. Please try again.";
                }
            }

            return RedirectToPage();
        }
    }
}

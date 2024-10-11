using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;

using KVSC.Infrastructure.DTOs.User.Register;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.Account
{
    public class SignUpModel : PageModel
    {
        private readonly IAuthService _authService;
        public SignUpModel(IAuthService authService)
        {
            _authService = authService;
        }

        [BindProperty]
        public SignUpRequest SignUpRequest { get; set; }

        [BindProperty]
        public List<ErrorDetail> ErrorMessage { get; set; }


        public async Task<IActionResult> OnPost()
        {

            ResponseDto<SignUpResponse> result = await _authService.SignUp(SignUpRequest);

            if (result.IsSuccess)
            {
                return RedirectToPage("/Account/Login"); // Redirect to homepage if login is successful
            }

            // Set error message from the response to be displayed on the page
            ErrorMessage = result.Errors;
            return Page(); // Reload the page to show the error
        }


        public void OnGet()
        {
        }
    }
}

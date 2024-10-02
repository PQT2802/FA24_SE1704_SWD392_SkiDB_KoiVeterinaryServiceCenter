using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Login;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text.Json;

namespace KoiVeterinaryServiceCenter_FE.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly IAuthService _authService;
        public LoginModel(IAuthService authService)
        {
            _authService = authService;
        }

        [BindProperty]
        public LoginRequest LoginRequest { get; set; }

        [BindProperty]
        public List<ErrorDetail> ErrorMessage { get; set; }

        public async Task<IActionResult> OnPost()
        {

            //if (LoginRequest.Email.Equals("a") && LoginRequest.Password.Equals("a")) { return RedirectToPage("/Index"); }
            ResponseDto<LoginResponse> result = await _authService.SignIn(LoginRequest);

            if (result.IsSuccess)
            {
                return RedirectToPage("/Index"); // Redirect to homepage if login is successful
            }

            // Set error message from the response to be displayed on the page
            ErrorMessage = result.Errors;
            //var error = new ErrorDetail()
            //{
            //    Code="1",
            //    Description ="test",
            //    Type="1"
            //};
            //ErrorMessage.Add(error);
            return Page(); // Reload the page to show the error
        }
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> OnPostGoogleSignInAsync([FromBody] GoogleSignInRequest request)
        {
            if (string.IsNullOrEmpty(request.IdToken))
            {
                return BadRequest("ID token is required.");
            }

            ResponseDto<LoginResponse> result = await _authService.GoogleSignIn(request);

            if (result.IsSuccess)
            {
                return RedirectToPage("/Index"); 
            }

            ErrorMessage = result.Errors;
            return Page(); 
        }


        public void OnGet()
        {
        }
    }
}

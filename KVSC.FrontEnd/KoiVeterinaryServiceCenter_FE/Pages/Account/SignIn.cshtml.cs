using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.DTOs.User;

namespace KoiVeterinaryServiceCenter_FE.Pages.Account
{
    public class SignInModel : PageModel
    {
        private readonly IAuthService _authService;
        public SignInModel(IAuthService authService)
        {
            _authService = authService;
        }

        [BindProperty]
        public LoginRequest LoginRequest { get; set; }

        [BindProperty]
        public List<ErrorDetail> ErrorMessage { get; set; }

        public async Task<IActionResult> OnPost()
        {

            ResponseDto<LoginResponse> result = await _authService.SignIn(LoginRequest);

            if (result.IsSuccess)
            {
                var accessToken = result.Data.AccessToken;
                var getResult = await _authService.GetUserInforByToken(accessToken);
                    if (getResult.IsSuccess)
                {
                    var userInfor = getResult.Data;
                }
                RedirectToPage("/Error");

                return RedirectToPage("/Index"); 
            }


            ErrorMessage = result.Errors;

            return Page(); // Reload the page to show the error
        }


        public void OnGet()
        {
        }
    }
}

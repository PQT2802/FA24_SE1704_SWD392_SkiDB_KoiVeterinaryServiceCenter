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
        public string ActorRole { get; set; }
        public async Task<IActionResult> OnPost()
        {
            // Call the authentication service
            ResponseDto<LoginResponse> result = await _authService.SignIn(LoginRequest);

            if (result.IsSuccess)
            {
                var accessToken = result.Data.Extensions.Data.AccessToken;
                var getResult = await _authService.GetUserInforByToken(accessToken);

                if (getResult.IsSuccess)
                {
                    var userInfor = getResult.Data;
                    HttpContext.Session.SetString("ActorRole", userInfor.RoleName);
                    HttpContext.Session.SetString("ActorName", userInfor.UserName);

                    // Redirect based on role
                    if (userInfor.RoleName == "Admin")
                    {
                        return RedirectToPage("/Admin/Dashboard");
                    }
                    else if (userInfor.RoleName == "Manager")
                    {
                        return RedirectToPage("/Manager/Dashboard");
                    }
                    else if (userInfor.RoleName == "Veterinarian")
                    {
                        return RedirectToPage("/Veterinarian/Dashboard");
                    }
                    else if (userInfor.RoleName == "Staff")
                    {
                        return RedirectToPage("/Staff/Dashboard");
                    }
                    else
                    {
                        // If no specific role is found, redirect to a default page
                        return RedirectToPage("/Index");
                    }
                }
            }

            // If login fails, display the error messages
            ErrorMessage = result.Errors;
            return Page();
        }


        public void OnGet()
        {
        }
    }
}

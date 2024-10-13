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
                    HttpContext.Session.SetString("ActorRole", userInfor.Extensions.Data.RoleName);
                    HttpContext.Session.SetString("ActorName", userInfor.Extensions.Data.UserName);
                    HttpContext.Session.SetString("Token", accessToken);

                    // Redirect based on role
                    if (userInfor.Extensions.Data.RoleName == "Admin")
                    {
                        return RedirectToPage("/User/Admin/Dashboard");
                    }
                    else if (userInfor.Extensions.Data.RoleName == "Manager")
                    {
                        return RedirectToPage("/User/Manager/Dashboard");
                    }
                    else if (userInfor.Extensions.Data.RoleName == "Veterinarian")
                    {
                        return RedirectToPage("/User/Veterinarian/Dashboard");
                    }
                    else if (userInfor.Extensions.Data.RoleName == "Staff")
                    {
                        return RedirectToPage("/User/Staff/Dashboard");
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

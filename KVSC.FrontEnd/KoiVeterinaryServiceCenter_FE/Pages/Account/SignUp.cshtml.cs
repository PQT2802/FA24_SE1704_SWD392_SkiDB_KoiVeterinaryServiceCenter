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
        public Dictionary<string, string> ErrorMessage { get; set; } = new Dictionary<string, string>();


        public async Task<IActionResult> OnPostSignUpAsync()
        {
            var result = await _authService.SignUp(SignUpRequest);

            if (result.IsSuccess)
            {
                return new JsonResult(new { isSuccess = true });
            }

            var errors = ProcessErrors(result.Errors);
            return new JsonResult(new { isSuccess = false, errors });
        }
        private Dictionary<string, string> ProcessErrors(List<ErrorDetail>? errors)
        {
            var errorDictionary = new Dictionary<string, List<string>>();

            if (errors != null)
            {
                foreach (var error in errors)
                {
                    string key = error.Code switch
                    {
                        "User.Empty" when error.Description.Contains("UserName", StringComparison.OrdinalIgnoreCase) => "UserName",
                        "User.Empty" when error.Description.Contains("Email", StringComparison.OrdinalIgnoreCase) => "Email",
                        "User.Empty" when error.Description.Contains("Password", StringComparison.OrdinalIgnoreCase) => "Password",
                        "User.Empty" when error.Description.Contains("FullName", StringComparison.OrdinalIgnoreCase) => "FullName",
                        "User.Empty" when error.Description.Contains("PhoneNumber", StringComparison.OrdinalIgnoreCase) => "PhoneNumber",
                        "User.Empty" when error.Description.Contains("Date of Birth", StringComparison.OrdinalIgnoreCase) => "DateOfBirth",
                        "User.Empty" when error.Description.Contains("address", StringComparison.OrdinalIgnoreCase) => "Address",
                        "User.Email.Format" => "Email",
                        "User.Email.Exist" => "Email",
                        "User.AgeRequirement" => "DateOfBirth",
                        "User.BirthdayInFuture" => "DateOfBirth",
                        "User.Phone.Format" => "PhoneNumber",
                        "User.UserName.Length" => "UserName",
                        "User.InvalidDate" => "DateOfBirth",
                        "User.Password.Length" => "Password",
                        "User.Password.Uppercase" => "Password",
                        "User.Password.SpecialChar" => "Password",
                        _ => string.Empty
                    };

                    if (!errorDictionary.ContainsKey(key))
                    {
                        errorDictionary[key] = new List<string>();
                    }
                    errorDictionary[key].Add(error.Description);
                }
            }

            return errorDictionary.ToDictionary(
                                    kvp => kvp.Key,
                                    kvp => string.Join(Environment.NewLine, kvp.Value) 
                                    );
        }


        public void OnGet()
        {
        }
    }
}

using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User.GetUser;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class QualificationModel : PageModel
    {
        private readonly IUserService _userService;
        [BindProperty]
        public GetVeterinarianResponse VeterinarianProfile { get; set; } = new();

        public QualificationModel(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IActionResult> OnGetAsync()
        {

            var token = HttpContext.Session.GetString("Token");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;

            if (!Guid.TryParse(userIdClaimString, out Guid userId))
            {
                ModelState.AddModelError(string.Empty, "Unable to decode userId from token.");
                return Page();
            }

            var result = await _userService.GetVeterinarianDetail(userId);
            VeterinarianProfile = result.IsSuccess ? result.Data ?? new GetVeterinarianResponse() : new GetVeterinarianResponse();

            return Page();
        }
        public async Task<IActionResult> OnPostUpdateQualificationsAsync(Guid userId, string specialty, string qualifications, string licenseNumber)
        {
            var token = HttpContext.Session.GetString("Token");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }
            var request = new GetVeterinarianRequest
            {
                UserId = userId,
                Specialty = specialty,
                Qualifications = qualifications,
                LicenseNumber = licenseNumber
            };

            // Save qualifications here using _userService or other logic
            var result = await _userService.UpdateVeterinarianQualifications(request);
            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Qualifications updated successfully.";
                return RedirectToPage(); // Redirect for TempData to persist
            }
            else
            {
                var errors = ProcessErrors(result.Errors);
                TempData["ErrorMessage"] = "Failed to update qualifications. Please check the form for errors.";

                // Optionally, you can store detailed errors for display in the view
                TempData["ValidationErrors"] = errors;

                return RedirectToPage();
            }
        }
        private Dictionary<string, string> ProcessErrors(List<ErrorDetail>? errors)
        {
            var errorDictionary = new Dictionary<string, string>();

            if (errors != null)
            {
                foreach (var error in errors)
                {
                    switch (error.Code)
                    {
                        case "User.LicenseNumberInvalidFormat":
                            errorDictionary["LicenseNumber"] = error.Description;
                            break;
                        case "User.SpecialtyInvalidLength":
                            errorDictionary["Specialty"] = error.Description;
                            break;
                        case "User.QualificationsInvalidLength":
                            errorDictionary["Qualifications"] = error.Description;
                            break;
                        default:
                            errorDictionary[string.Empty] = error.Description;  // For unhandled errors
                            break;
                    }
                }
            }

            return errorDictionary;
        }
    }
}

using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.User.GetUser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class CreateMyQualificationModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public GetVeterinarianRequest Veterinarian { get; set; }

        public string ErrorMessage { get; set; }

        public CreateMyQualificationModel(IUserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
            // This could be used to populate default values, if necessary
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var token = HttpContext.Session.GetString("Token");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;

            if (!Guid.TryParse(userIdClaimString, out Guid currentUserId))
            {
                ModelState.AddModelError(string.Empty, "Unable to decode userId from token..");
                return Page();
            }
            Veterinarian.UserId = currentUserId;
            // Call service to create the veterinarian
            var response = await _userService.CreateVeterinarian(Veterinarian);

            if (response.IsSuccess)
            {
                // Redirect or show a success message
                return RedirectToPage("/User/Veterinarian/Qualification"); // Assuming you have a success page
            }
            else
            {
                // Display error message
                ErrorMessage = response.Message;
                return Page();
            }
        }
    }
}

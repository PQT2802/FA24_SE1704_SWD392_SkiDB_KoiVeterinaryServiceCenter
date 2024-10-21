using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.User.GetUser;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Customer
{
    public class CustomerProfileModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public GetUserResponse UserProfile { get; set; } = new();

        [BindProperty]
        public UpdateUserRequest UpdateUserRequest { get; set; } = default!;

        public CustomerProfileModel(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> OnGetAsync(bool? editCustom = null)
        {
            ViewData["IsEditMode"] = editCustom ?? false;

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

            var result = await _userService.GetUserDetail(userId);
            UserProfile = result.IsSuccess ? result.Data ?? new GetUserResponse() : new GetUserResponse();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
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
            UpdateUserRequest.Id = userId;
            var result = await _userService.UpdateUser(UpdateUserRequest);
            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Profile updated successfully.";
                return Redirect("/User/Admin/AdminProfile");
            }
            else
            {
                TempData["ErrorMessage"] = string.Join(", ", result.Errors.Select(e => e.Description));
                return Redirect("/User/Admin/AdminProfile");
            }
            ViewData["IsEditMode"] = true;
            return Redirect("/User/Admin/AdminProfile");
        }
    }
}

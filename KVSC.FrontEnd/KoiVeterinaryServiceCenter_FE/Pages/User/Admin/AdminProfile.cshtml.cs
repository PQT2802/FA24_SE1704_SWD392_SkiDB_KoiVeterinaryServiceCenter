using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User.GetUser;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Admin
{
    public class AdminProfileModel : PageModel
    {
        private readonly IUserService _userService;
        
        [BindProperty]
        public GetUserResponse UserProfile { get; set; } = new();

        [BindProperty]
        public UpdateUserRequest UpdateUserRequest { get; set; } = default!;

        public AdminProfileModel(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> OnGetAsync(bool? edit = null)
        {
            ViewData["IsEditMode"] = edit ?? false; 

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
        public async Task<IActionResult> OnPostAsync(IFormFile imageFile)
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
            UpdateUserRequest.Role = 1;
            if (imageFile == null || imageFile.Length == 0)
            {
                UpdateUserRequest.ProfilePictureUrl = Request.Form["ExistingProfilePictureUrl"];
            }
            var result = await _userService.UpdateUser(UpdateUserRequest, imageFile);
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

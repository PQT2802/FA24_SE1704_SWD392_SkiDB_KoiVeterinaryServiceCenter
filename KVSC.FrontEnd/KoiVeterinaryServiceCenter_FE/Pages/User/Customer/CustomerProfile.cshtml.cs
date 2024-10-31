using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
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
        [BindProperty]
        public decimal TopUpAmount { get; set; }

        public CustomerProfileModel(IUserService userService)
        {
            _userService = userService;
        }

        // Handles the initial GET request, capturing query parameters for token, message, and type
        public async Task<IActionResult> OnGetAsync(bool? edit = null, string token = null, string message = null, string type = null)
        {
            // Store the token in session if provided
            if (!string.IsNullOrEmpty(token))
            {
                HttpContext.Session.SetString("Token", token);
            }

            // Handle messages
            if (!string.IsNullOrEmpty(message) && !string.IsNullOrEmpty(type))
            {
                if (type == "success")
                {
                    TempData["SuccessMessage"] = message;
                }
                else
                {
                    TempData["ErrorMessage"] = message;
                }
            }

            // Proceed to load the user profile with optional edit mode
            return await LoadUserProfile(edit);
        }

        // Separate method to load the user's profile details
        private async Task<IActionResult> LoadUserProfile(bool? edit = null)
        {
            ViewData["IsEditMode"] = edit ?? false;

            // Retrieve token from session
            var token = HttpContext.Session.GetString("Token");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }

            // Decode userId from the token
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;
            if (!Guid.TryParse(userIdClaimString, out Guid userId))
            {
                ModelState.AddModelError(string.Empty, "Unable to decode userId from token.");
                return Page();
            }

            // Fetch user details
            var result = await _userService.GetUserDetail(userId);
            if (result.IsSuccess && result.Data != null)
            {
                UserProfile = result.Data;
                UserProfile.Extensions ??= new Extensions<GetUserData>(); // Initialize Extensions if null
            }
            else
            {
                UserProfile = new GetUserResponse { Extensions = new Extensions<GetUserData>() };
            }

            return Page();
        }

        // Handle user profile update with optional image file
        public async Task<IActionResult> OnPostAsync(IFormFile imageFile)
        {
            var token = HttpContext.Session.GetString("Token");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }

            // Decode userId from the token
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;
            if (!Guid.TryParse(userIdClaimString, out Guid userId))
            {
                ModelState.AddModelError(string.Empty, "Unable to decode userId from token.");
                return Page();
            }

            UpdateUserRequest.Id = userId;
            UpdateUserRequest.Role = 5; // Set the role as required
            var result = await _userService.UpdateUser(UpdateUserRequest, imageFile);
            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Profile updated successfully.";
                return Redirect("/User/Customer/CustomerProfile");
            }
            else
            {
                TempData["ErrorMessage"] = string.Join(", ", result.Errors.Select(e => e.Description));
                return Redirect("/User/Customer/CustomerProfile");
            }
        }

        // Handle wallet top-up
        public async Task<IActionResult> OnPostTopUpAsync()
        {
            var token = HttpContext.Session.GetString("Token");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }

            if (TopUpAmount <= 10000)
            {
                ModelState.AddModelError(string.Empty, "Please enter a valid amount to add (more than 10000).");
                return Redirect("/User/Customer/CustomerProfile");
            }

            var result = await _userService.TopUpWallet(token, TopUpAmount);
            if (result.IsSuccess)
            {
                return Redirect(result.Data.Extensions.Data.Url);
            }
            else
            {
                TempData["ErrorMessage"] = "Failed to add money: " + string.Join(", ", result.Errors.Select(e => e.Description));
                return Redirect("/User/Customer/CustomerProfile");
            }
        }
    }
}

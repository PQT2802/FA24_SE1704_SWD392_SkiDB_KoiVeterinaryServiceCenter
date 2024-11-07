using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Dashboard.Veterinarian;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;


namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class DashboardModel : PageModel
    {
        private readonly IDashboardService _dashboardService;

        public DashboardModel(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [BindProperty]
        public GetVetDashboardData DashboardData { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            // Retrieve the JWT token from session storage
            var token = HttpContext.Session.GetString("Token");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }

            // Parse the token to extract veterinarianId
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;

            if (!Guid.TryParse(userIdClaimString, out Guid veterinarianId))
            {
                ModelState.AddModelError(string.Empty, "Unable to decode veterinarianId from token.");
                return Page();
            }

            // Fetch veterinarian dashboard data using the dashboard service
            var result = await _dashboardService.GetVetDashboardAsync(veterinarianId);

            if (result.IsSuccess)
            {
                // Assign the data to the DashboardData property
                DashboardData = result.Data?.Extensions?.Data ?? new GetVetDashboardData();
            }
            else
            {
                // Add an error if the API call fails
                ModelState.AddModelError(string.Empty, "Error fetching veterinarian dashboard data.");
            }

            return Page();
        }
    }
}

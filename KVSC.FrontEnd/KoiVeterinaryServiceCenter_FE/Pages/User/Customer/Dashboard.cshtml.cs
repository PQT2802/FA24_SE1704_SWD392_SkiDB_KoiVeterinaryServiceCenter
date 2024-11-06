using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Dashboard.Customer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Customer
{
    public class DashboardModel : PageModel
    {
        private readonly IDashboardService _dashboardService;

        public DashboardModel(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [BindProperty]
        public GetCustomerDashboardData DashboardData { get; set; } = default!;

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

            if (!Guid.TryParse(userIdClaimString, out Guid customerId))
            {
                ModelState.AddModelError(string.Empty, "Unable to decode userId from token.");
                return Page();
            }

            var result = await _dashboardService.GetCustomerDashboardAsync(customerId);

            if (result.IsSuccess)
            {
                DashboardData = result.Data?.Extensions?.Data ?? new GetCustomerDashboardData();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error fetching dashboard data.");
            }

            return Page();
        }
    }
}

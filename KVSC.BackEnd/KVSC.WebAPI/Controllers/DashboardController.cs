using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashBoardService _dashboardService;

        public DashboardController(IDashBoardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet("AdminDashboard")]
        public async Task<IResult> GetDashboardData()
        {
            var result = await _dashboardService.GetDashboardDataAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Admin dashboard data retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("VeterinarianDashboard")]
        public async Task<IResult> GetVeterinarianDashboardData()
        {
            var result = await _dashboardService.GetVeterinarianDashboardDataAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Veterinarian dashboard data retrieved successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("ManagerDashboard")]
        public async Task<IResult> GetManagerDashboardData()
        {
            var result = await _dashboardService.GetManagerDashboardDataAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Manager dashboard data retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("CustomerDashboard/{customerId}")]
        public async Task<IResult> GetCustomerDashboardData(Guid customerId)
        {
            var result = await _dashboardService.GetCustomerDashboardDataAsync(customerId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Customer dashboard data retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}

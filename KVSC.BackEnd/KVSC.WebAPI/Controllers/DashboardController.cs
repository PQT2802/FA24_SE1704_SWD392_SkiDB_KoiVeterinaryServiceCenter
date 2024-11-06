using KVSC.Application.Common;
using KVSC.Application.Implement.Service;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common;
using Microsoft.AspNetCore.Authorization;
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
            Result result = await _dashboardService.GetDashboardDataAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Admin dashboard data retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("VeterinarianDashboard")]
        public async Task<IResult> GetVeterinarianDashboardData()
        {
            Result result = await _dashboardService.GetVeterinarianDashboardDataAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Veterinarian dashboard data retrieved successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("ManagerDashboard/{managerId}")]
        public async Task<IResult> GetManagerDashboardData(Guid managerId)
        {
            Result result = await _dashboardService.GetManagerDashboardDataAsync(managerId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Manager dashboard data retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("CustomerDashboard/{customerId}")]
        public async Task<IResult> GetCustomerDashboardData(Guid customerId)
        {
            Result result = await _dashboardService.GetCustomerDashboardDataAsync(customerId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Customer dashboard data retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}

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

        [HttpGet("Admin/Dashboard")]
        public async Task<IResult> GetDashboardData()
        {
            var result = await _dashboardService.GetDashboardDataAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Dashboard data retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

    }
}

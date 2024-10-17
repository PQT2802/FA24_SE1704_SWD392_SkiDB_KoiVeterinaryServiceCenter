using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;
using KVSC.Infrastructure.DTOs.ServiceReport.GetServiceReport;
using KVSC.Infrastructure.DTOs.ServiceReport.UpdateServiceReport;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    
        [ApiController]
        [Route("api/[controller]")]
        public class ServiceReportController : ControllerBase
        {
            private readonly IServiceReportService _serviceReportService;

            public ServiceReportController(IServiceReportService serviceReportService)
            {
                _serviceReportService = serviceReportService;
            }

            // Add a new service report
            [HttpPost("add")]
            public async Task<IResult> AddServiceReportAsync([FromBody] AddServiceReportRequest request)
            {
                var result = await _serviceReportService.AddServiceReportAsync(request);
            return result.IsSuccess
            ? ResultExtensions.ToSuccessDetails(result, "Report created successfully")
            : ResultExtensions.ToProblemDetails(result);
        }

            // Get a service report by ID
            [HttpGet("{id}")]
            public async Task<IActionResult> GetServiceReportByIdAsync(Guid id)
            {
                var result = await _serviceReportService.GetServiceReportByIdAsync(id);
                if (result.IsSuccess)
                    return Ok(result);
                return NotFound(result.Errors);
            }

            // Get multiple service reports with filtering
            [HttpGet("search")]
            public async Task<IActionResult> GetServiceReportsAsync([FromQuery] SearchServiceReportRequest request)
            {
                var result = await _serviceReportService.GetServiceReportsAsync(request);
                if (result.IsSuccess)
                    return Ok(result);
                return BadRequest(result.Errors);
            }

            // Update a service report
            [HttpPut("update")]
            public async Task<IActionResult> UpdateServiceReportAsync([FromBody] UpdateServiceReportRequest request)
            {
                var result = await _serviceReportService.UpdateServiceReportAsync(request);
                if (result.IsSuccess)
                    return Ok(result);
                return BadRequest(result.Errors);
            }

            // Delete a service report by ID
            [HttpDelete("delete/{id}")]
            public async Task<IActionResult> DeleteServiceReportAsync(Guid id)
            {
                var result = await _serviceReportService.DeleteServiceReportAsync(id);
                if (result.IsSuccess)
                    return Ok(result);
                return NotFound(result.Errors);
            }
        }
    }


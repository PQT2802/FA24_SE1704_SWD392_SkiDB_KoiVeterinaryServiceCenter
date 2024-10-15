using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.ComboService.GetComboService;
using KVSC.Infrastructure.DTOs.ComboService.UpdateComboService;
using KVSC.Infrastructure.DTOs.Pet.AddComboService;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComboServiceController : ControllerBase
    {
        private readonly IComboServiceService _comboServiceService;

        public ComboServiceController(IComboServiceService comboServiceService)
        {
            _comboServiceService = comboServiceService;
        }

        // POST: api/comboservice
        [HttpPost]
        public async Task<IResult> CreateComboService([FromBody] AddComboServiceRequest addComboService)
        {
            Result result = await _comboServiceService.CreateComboServiceAsync(addComboService);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Combo service created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("all")]
        public async Task<IResult> GetAllComboServices()
        {
            Result result = await _comboServiceService.GetAllComboServicesAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Combo services retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        // GET: api/comboservice/{id}
        [HttpGet]
        public async Task<IResult> GetComboServiceById([FromQuery] GetComboServiceRequest request)
        {
            Result result = await _comboServiceService.GetComboServiceByIdAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Combo service retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // PUT: api/comboservice/{id}
        [HttpPut]
        public async Task<IResult> UpdateComboService([FromBody] UpdateComboServiceRequest request)
        {
            Result result = await _comboServiceService.UpdateComboServiceAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Combo service updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // DELETE: api/comboservice/{id}
        [HttpDelete]
        public async Task<IResult> DeleteComboService([FromQuery] GetComboServiceRequest request)
        {
            Result result = await _comboServiceService.DeleteComboServiceAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Combo service deleted successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}

using Azure.Core;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.PetServiceCategory.AddPetServiceCategroy;
using KVSC.Infrastructure.DTOs.PetServiceCategory.GetPetServiceCategory;
using KVSC.Infrastructure.DTOs.PetServiceCategory.UpdatePetServiceCategory;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetServiceCategoryController : ControllerBase
    {
        private readonly IPetServiceCategoryService _petServiceCategoryService;

        public PetServiceCategoryController(IPetServiceCategoryService petServiceCategoryService)
        {
            _petServiceCategoryService = petServiceCategoryService;
        }

        // POST: api/petservicecategory
        [HttpPost]
        public async Task<IResult> CreatePetServiceCategory([FromBody] AddPetServiceCategoryRequest addPetServiceCategory)
        {
            Result result = await _petServiceCategoryService.CreatePetServiceCategoryAsync(addPetServiceCategory);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service category created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/petservicecategory
        [HttpGet("all")]
        public async Task<IResult> GetAllPetServiceCategories()
        {
            Result result = await _petServiceCategoryService.GetAllPetServiceCategoriesAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "All pet service categories retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/petservicecategory/{id}
        [HttpGet]
        public async Task<IResult> GetPetServiceCategoryById([FromQuery] GetPetServiceCategoryRequest request)
        {
            Result result = await _petServiceCategoryService.GetPetServiceCategoryByIdAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service category retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // PUT: api/petservicecategory/{id}
        [HttpPut]
        public async Task<IResult> UpdatePetServiceCategory([FromBody] UpdatePetServiceCategoryRequest updatePetServiceRequest)
        {
            Result result = await _petServiceCategoryService.UpdatePetServiceCategoryAsync(updatePetServiceRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service category updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // DELETE: api/petservicecategory/{id}
        [HttpDelete]
        public async Task<IResult> DeletePetServiceCategory([FromQuery] GetPetServiceCategoryRequest request)
        {
            Result result = await _petServiceCategoryService.DeletePetServiceCategoryAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Pet service category deleted successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}

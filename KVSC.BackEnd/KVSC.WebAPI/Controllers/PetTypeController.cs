using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Pet.AddPetType;
using KVSC.Infrastructure.DTOs.Pet.UpdatePetType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetTypeController : ControllerBase
    {
        //private readonly IPetTypeService _petTypeService;

        //public PetTypeController(IPetTypeService petTypeService)
        //{
        //    _petTypeService = petTypeService;
        //}

        ///// <summary>
        ///// Get a pet type by its ID.
        ///// </summary>
        //[HttpGet("{id}")]
        //public async Task<IResult> GetPetTypeById(Guid id)
        //{
        //    Result result = await _petTypeService.GetPetTypeByIdAsync(id);
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "View pet type successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}

        ///// <summary>
        ///// Get all pet types.
        ///// </summary>
        //[HttpGet("All-pet-types")]
        //public async Task<IResult> GetAllPetTypes()
        //{
        //    var result = await _petTypeService.GetAllPetTypesAsync();
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "View all pet types successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}

        ///// <summary>
        ///// Add a new pet type to the system.
        ///// </summary>
        //[HttpPost("Create-pet-type")]
        //public async Task<IResult> CreatePetType([FromBody] AddPetTypeRequest addPetTypeDto)
        //{
        //    Result result = await _petTypeService.CreatePetTypeAsync(addPetTypeDto);
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "Create pet type successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}

        ///// <summary>
        ///// Update an existing pet type.
        ///// </summary>
        //[HttpPut("Update-pet-type/{id}")]
        //public async Task<IResult> UpdatePetType(Guid id, [FromBody] UpdatePetTypeRequest updatePetTypeDto)
        //{
        //    Result result = await _petTypeService.UpdatePetTypeAsync(id, updatePetTypeDto);
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "Update pet type successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}

        ///// <summary>
        ///// Delete a pet type by its ID.
        ///// </summary>
        //[HttpDelete("Delete-pet-type/{id}")]
        //public async Task<IResult> DeletePetType(Guid id)
        //{
        //    Result result = await _petTypeService.DeletePetTypeAsync(id);
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "Delete pet type successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}
    }
}

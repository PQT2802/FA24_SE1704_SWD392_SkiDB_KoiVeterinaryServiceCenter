using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Pet.AddPetHabitat;
using KVSC.Infrastructure.DTOs.Pet.UpdatePetHabitat;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetHabitatController : ControllerBase
    {
        //private readonly IPetHabitatService _petHabitatService;

        //public PetHabitatController(IPetHabitatService petHabitatService)
        //{
        //    _petHabitatService = petHabitatService;
        //}

        //[HttpGet("{id}")]
        //public async Task<IResult> GetPetHabitatById(Guid id)
        //{
        //    Result result = await _petHabitatService.GetPetHabitatByIdAsync(id);
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "View pet habitat successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}

        //[HttpGet("All-pet-habitats")]
        //public async Task<IResult> GetAllPetHabitats()
        //{
        //    var result = await _petHabitatService.GetAllPetHabitatsAsync();
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "View all pet habitats successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}

        //[HttpPost("Create-pet-habitat")]
        //public async Task<IResult> CreatePetHabitat([FromBody] AddPetHabitatRequest addPetHabitatRequest)
        //{
        //    Result result = await _petHabitatService.CreatePetHabitatAsync(addPetHabitatRequest);
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "Create pet habitat successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}

        //[HttpPut("Update-pet-habitat/{id}")]
        //public async Task<IResult> UpdatePetHabitat(Guid id, [FromBody] UpdatePetHabitatRequest updatePetHabitatRequest)
        //{
        //    Result result = await _petHabitatService.UpdatePetHabitatAsync(id, updatePetHabitatRequest);
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "Update pet habitat successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}

        //[HttpDelete("Delete-pet-habitat/{id}")]
        //public async Task<IResult> DeletePetHabitat(Guid id)
        //{
        //    Result result = await _petHabitatService.DeletePetHabitatAsync(id);
        //    return result.IsSuccess
        //        ? ResultExtensions.ToSuccessDetails(result, "Delete pet habitat successfully")
        //        : ResultExtensions.ToProblemDetails(result);
        //}
    }
}

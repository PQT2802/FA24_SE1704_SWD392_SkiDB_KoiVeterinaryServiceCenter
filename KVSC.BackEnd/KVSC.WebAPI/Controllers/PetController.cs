using KVSC.Application.Common;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.GetPet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IPetBusinessService _petBusinessService;

        public PetController(IPetBusinessService petBusinessService, IHttpContextAccessor contextAccessor)
        {
            _petBusinessService = petBusinessService;
            _contextAccessor = contextAccessor;
        }

        //GET: api/pet/{id}
        [HttpGet]
        public async Task<IResult> GetPetById([FromQuery] GetPetRequest request)
        {
            Result result = await _petBusinessService.GetPetByIdAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "View pet successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        //GET: api/pet/all
        [HttpGet("all")]
        public async Task<IResult> GetAllPet()
        {
            Result result = await _petBusinessService.GetAllPetAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "View all pets successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        //POST: api/pet
        [HttpPost]
        public async Task<IResult> CreatePet([FromBody] AddPetRequest addPet)
        {
            Result result = await _petBusinessService.CreatePetAsync(addPet);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Create pet successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        //PUT: api/pet/{id}
        [HttpPut]
        public async Task<IResult> UpdatePet([FromBody] UpdatePetRequest updatePet)
        {
            Result result = await _petBusinessService.UpdatePetAsync(updatePet);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Update pet successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        //DELETE: api/pet/{id}
        [HttpDelete]
        public async Task<IResult> DeletePet([FromBody] GetPetRequest request)
        {
            Result result = await _petBusinessService.DeletePetAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Delete pet successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [Authorize]
        [HttpGet("owner-pet")]
        public async Task<IResult> GetAllPetByOwnerId()
        {
            CurrentUserObject c = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            Result result = await _petBusinessService.GetAllPetByOwnerIdAsync(c.UserId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "View all pets by ownerId successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

    }
}

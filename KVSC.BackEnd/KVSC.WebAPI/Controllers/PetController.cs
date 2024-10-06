﻿using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetBusinessService _petBusinessService;

        public PetController(IPetBusinessService petBusinessService)
        {
            _petBusinessService = petBusinessService;
        }


        /// <summary>
        /// Get a pet by its ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IResult> GetPetById(Guid id)
        {
            Result result = await _petBusinessService.GetPetByIdAsync(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "View pet successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        /// <summary>
        /// Get all pets.
        /// </summary>
        [HttpGet("All-pet")]
        public async Task<IResult> GetAllPet()
        {
            var result = await _petBusinessService.GetAllPetAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "View all pets successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        /// <summary>
        /// Add a new pet to the system.
        /// </summary>
        [HttpPost("Create-pet")]
        public async Task<IResult> CreatePet([FromBody] AddPetRequest addPet)
        {
            Result result = await _petBusinessService.CreatePetAsync(addPet);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Create pet successfully")
                : ResultExtensions.ToProblemDetails(result);
        }


        /// <summary>
        /// Update an existing pet.
        /// </summary>
        [HttpPut("Update-pet")]
        public async Task<IResult> UpdatePet(Guid id, [FromBody] UpdatePetRequest updatePet)
        {
            Result result = await _petBusinessService.UpdatePetAsync(id, updatePet);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Update pet successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        /// <summary>
        /// Delete a pet by its ID.
        /// </summary>
        [HttpDelete("Delete-pet/{id}")]
        public async Task<IResult> DeletePet(Guid id)
        {
            Result result = await _petBusinessService.DeletePetAsync(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Delete pet successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}
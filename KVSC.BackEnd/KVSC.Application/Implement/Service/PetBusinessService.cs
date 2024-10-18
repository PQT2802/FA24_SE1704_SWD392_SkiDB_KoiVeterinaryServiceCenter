using FluentValidation;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.DTOs.Pet.GetPet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.DTOs.PetService.GetPetService;
using KVSC.Infrastructure.Implement.Repositories;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class PetBusinessService : IPetBusinessService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<AddPetRequest> _addPetRequestValidator;
        private readonly IValidator<UpdatePetRequest> _updatePetRequestValidator;


        public PetBusinessService(IUnitOfWork unitOfWork,
            IValidator<AddPetRequest> addPetRequestValidator,
            IValidator<UpdatePetRequest> updatePetRequestValidator)
        {
            _unitOfWork = unitOfWork;
            _addPetRequestValidator = addPetRequestValidator;
            _updatePetRequestValidator = updatePetRequestValidator;
        }

        public async Task<Result> GetPetByIdAsync(Guid id)
        {
            var pet = await _unitOfWork.PetRepository.GetPetByIdAsync(id);
            if (pet == null)
            {
                return Result.Failure(PetErrorMessage.PetNotFound());
            }

            var petResponse = new GetPetResponse
            {
                Id = pet.Id,
                Name = pet.Name,
                Age = pet.Age ?? 0,
                Gender = pet.Gender ?? "",
                ImageUrl = pet.ImageUrl,
                Color = pet.Color ?? "",
                Length = pet.Length ?? 0,
                Weight = pet.Weight ?? 0,
                LastHealthCheck = pet.LastHealthCheck,
                HealthStatus = pet.HealthStatus,
                OwnerId = pet.OwnerId
            };

            return Result.SuccessWithObject(petResponse);
        }

        public async Task<Result> GetAllPetAsync()
        {
            var pets = await _unitOfWork.PetRepository.GetAllPetAsync();
            var petResponse = pets.Select(pet => new GetPetResponse
            {
                Id = pet.Id,
                Name = pet.Name ?? "",
                Age = pet.Age ?? 0,
                Gender = pet.Gender ?? "",
                ImageUrl = pet.ImageUrl ?? "",
                Color = pet.Color ?? "",
                Length = pet.Length ?? 0,
                Weight = pet.Weight ?? 0,
                LastHealthCheck = pet.LastHealthCheck,
                HealthStatus = pet.HealthStatus,
                OwnerId = pet.OwnerId
            }).ToList();

            return Result.SuccessWithObject(petResponse);
        }

        public async Task<Result> CreatePetAsync(AddPetRequest addPet)
        {
            var validate = await _addPetRequestValidator.ValidateAsync(addPet);
            if (!validate.IsValid)
            {
                var errors = validate.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();

                return Result.Failures(errors);
            }

            //check if pet has user 
            var owner = await _unitOfWork.UserRepository.GetByIdAsync(addPet.OwnerId);
            if (owner == null)
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }

            var pet = new Pet
            {
                Id = Guid.NewGuid(),
                Name = addPet.Name,
                Age = addPet.Age,
                Gender = addPet.Gender,
                ImageUrl = addPet.ImageUrl,
                Color = addPet.Color,
                Length = addPet.Length,
                Weight = addPet.Weight,
                LastHealthCheck = addPet.LastHealthCheck,
                HealthStatus = addPet.HealthStatus,
                OwnerId = addPet.OwnerId
            };

            var createResult = await _unitOfWork.PetRepository.CreatePetAsync(pet);
            if (createResult == null)
            {
                return Result.Failure(PetErrorMessage.PetCreateFailed());
            }

            var response = new AddPetResponse { Id = pet.Id };
            return Result.SuccessWithObject(response);
        }

        public async Task<Result> UpdatePetAsync(UpdatePetRequest updatePet)
        {
            var validate = await _updatePetRequestValidator.ValidateAsync(updatePet);
            if (!validate.IsValid)
            {
                var errors = validate.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();

                return Result.Failures(errors);
            }

            var pet = await _unitOfWork.PetRepository.GetPetByIdAsync(updatePet.Id);
            if (pet == null)
            {
                return Result.Failure(PetErrorMessage.PetNotFound());
            }

            pet.Name = updatePet.Name;
            pet.Age = updatePet.Age;
            pet.Gender = updatePet.Gender;
            pet.ImageUrl = updatePet.ImageUrl;
            pet.Color = updatePet.Color;
            pet.Length = updatePet.Length;
            pet.Weight = updatePet.Weight;
            pet.LastHealthCheck = updatePet.LastHealthCheck;
            pet.HealthStatus = updatePet.HealthStatus;

            var updateResult = await _unitOfWork.PetRepository.UpdatePetAsync(pet);
            if (updateResult == 0)
            {
                return Result.Failure(PetErrorMessage.PetUpdateFailed());
            }

            var response = new AddPetResponse { Id = pet.Id };
            return Result.SuccessWithObject(response);
        }

        public async Task<Result> DeletePetAsync(Guid id)
        {
            var pet = await _unitOfWork.PetRepository.GetPetByIdAsync(id);
            if (pet == null)
            {
                return Result.Failure(PetErrorMessage.PetNotFound());
            }

            var deleteResult = await _unitOfWork.PetRepository.DeletePetAsync(id);
            if (deleteResult == 0)
            {
                return Result.Failure(PetErrorMessage.PetDeleteFailed());
            }

            return Result.SuccessWithObject(deleteResult);
        }

        public async Task<Result> GetAllPetByOwnerIdAsync(Guid ownerId)
        {
            var pets = await _unitOfWork.PetRepository.GetAllPetsByOwnerIdAsync(ownerId);
            if (pets == null)
            {
                return Result.Failure(PetErrorMessage.PetNotFound());
            }

            var petResponseList = pets.Select(pet => new UpdatePetResponse 
            {
                Id = pet.Id,
                Name = pet.Name,
                Age = pet.Age ?? 0,
                Gender = pet.Gender ?? "",
                ImageUrl = pet.ImageUrl?? "",
                Color = pet.Color ?? "",
                Length = pet.Length ?? 0,
                Weight = pet.Weight ?? 0,
                LastHealthCheck = pet.LastHealthCheck,
                HealthStatus = pet.HealthStatus
            }).ToList();

            return Result.SuccessWithObject(petResponseList);
        }
    }
}

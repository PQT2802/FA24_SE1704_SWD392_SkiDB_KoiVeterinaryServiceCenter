﻿using Azure;
using FluentValidation;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.DTOs.PetService.GetPetService;
using KVSC.Infrastructure.DTOs.PetService.UpdatePetService;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class PetServiceService : IPetServiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<AddPetServiceRequest> _petServiceValidator;
        private readonly IValidator<UpdatePetServiceRequest> _updatePetServiceValidator;

        public PetServiceService(IUnitOfWork unitOfWork, IValidator<AddPetServiceRequest> petServiceValidator, IValidator<UpdatePetServiceRequest> updatePetServiceValidator)
        {
            _unitOfWork = unitOfWork;
            _petServiceValidator = petServiceValidator;
            _updatePetServiceValidator = updatePetServiceValidator;
        }

        public async Task<Result> CreatePetServiceAsync(AddPetServiceRequest addPetService)
        {
            // Validate the input
            var validationResult = await _petServiceValidator.ValidateAsync(addPetService);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            var categoryExists = await _unitOfWork.PetServiceCategoryRepository.GetByIdAsync(addPetService.PetServiceCategoryId);
            if (categoryExists == null)
            {
                return Result.Failure(PetServiceErrorMessage.InvalidFieldValue("PetServiceCategory"));
            }

            var petService = new PetService
            {
                Name = addPetService.Name,
                PetServiceCategoryId = addPetService.PetServiceCategoryId,
                BasePrice = addPetService.BasePrice,
                Duration = addPetService.Duration,
                ImageUrl = addPetService.ImageUrl,
                AvailableFrom = addPetService.AvailableFrom,
                AvailableTo = addPetService.AvailableTo,
                TravelCost = addPetService.TravelCost,
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false,
                OrderItems = new List<OrderItem>(),
            };

            // Create the service
            var createResult = await _unitOfWork.PetServiceRepository.CreateServiceAsync(petService);
            if (createResult == null)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceNotCreated());
            }
            var response = new CreateResponse { Id = petService.Id };
            return Result.SuccessWithObject(response);
        }

        public async Task<Result> GetAllPetServicesAsync()
        {
            var petServices = await _unitOfWork.PetServiceRepository.GetAllServicesAsync();
            var petServiceRespone = petServices.Select(service => new GetPetServiceResponse
            {
                Id = service.Id,
                Name = service.Name,
                BasePrice = service.BasePrice,
                Duration = service.Duration,
                ImageUrl = service.ImageUrl,
                AvailableFrom = service.AvailableFrom,
                AvailableTo = service.AvailableTo,
                TravelCost = service.TravelCost,
                ServiceCategory = service.PetServiceCategory?.Name,
                PetServiceCategoryId = service.PetServiceCategoryId
            }).ToList();
            return Result.SuccessWithObject(petServiceRespone);
        }

        public async Task<Result> GetPetServiceByIdAsync(Guid id)
        {
            var petService = await _unitOfWork.PetServiceRepository.GetServiceByIdAsync(id);
            if (petService == null)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceNotFound());
            }
            var petServiceRespone = new GetPetServiceResponse 
            { 
                Id = petService.Id,
                Name = petService.Name,
                BasePrice = petService.BasePrice,
                Duration = petService.Duration,
                ImageUrl = petService.ImageUrl,
                AvailableFrom = petService.AvailableFrom,
                AvailableTo = petService.AvailableTo,
                TravelCost = petService.TravelCost,
                ServiceCategory = petService.PetServiceCategory?.Name,
                PetServiceCategoryId = petService.PetServiceCategoryId
            };

            return Result.SuccessWithObject(petServiceRespone);
        }

        public async Task<Result> UpdatePetServiceAsync(UpdatePetServiceRequest updatePetServiceRequest)
        {
            // Validate the input
            var validationResult = await _updatePetServiceValidator.ValidateAsync(updatePetServiceRequest);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }
            var existingPetService = await _unitOfWork.PetServiceRepository.GetServiceByIdAsync(updatePetServiceRequest.Id);
            if (existingPetService == null)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceNotFound());
            }
            var categoryExists = await _unitOfWork.PetServiceCategoryRepository.GetByIdAsync(updatePetServiceRequest.PetServiceCategoryId);
            if (categoryExists == null)
            {
                return Result.Failure(PetServiceErrorMessage.InvalidFieldValue("PetServiceCategory"));
            }
            // Update the properties
            existingPetService.Name = updatePetServiceRequest.Name; // Update Name
            existingPetService.PetServiceCategoryId = updatePetServiceRequest.PetServiceCategoryId;
            existingPetService.BasePrice = updatePetServiceRequest.BasePrice;
            existingPetService.Duration = updatePetServiceRequest.Duration;
            existingPetService.ImageUrl = updatePetServiceRequest.ImageUrl;
            existingPetService.AvailableFrom = updatePetServiceRequest.AvailableFrom;
            existingPetService.AvailableTo = updatePetServiceRequest.AvailableTo;
            existingPetService.TravelCost = updatePetServiceRequest.TravelCost;
            existingPetService.ModifiedDate = DateTime.UtcNow;

            // Update the service
            var updateResult = await _unitOfWork.PetServiceRepository.UpdateAsync(existingPetService);

            if (updateResult == 0)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceUpdateFailed());
            }

            var response = new CreateResponse { Id = existingPetService.Id };
            return Result.SuccessWithObject(response);
        }

        public async Task<Result> DeletePetServiceAsync(Guid id)
        {
            var existingPetService = await _unitOfWork.PetServiceRepository.GetServiceByIdAsync(id);
            if (existingPetService == null)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceNotFound());
            }
            var deleteResult = await _unitOfWork.PetServiceRepository.DeleteServiceAsync(id);
            if (deleteResult == 0)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceDeleteFailed());
            }

            return Result.SuccessWithObject(deleteResult);
        }
    }
}

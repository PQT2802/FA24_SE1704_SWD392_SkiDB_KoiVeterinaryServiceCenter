using FluentValidation;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
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
        private readonly IValidator<AddPetServiceDTO> _petServiceValidator;

        public PetServiceService(IUnitOfWork unitOfWork, IValidator<AddPetServiceDTO> petServiceValidator)
        {
            _unitOfWork = unitOfWork;
            _petServiceValidator = petServiceValidator;
        }

        public async Task<Result> CreatePetServiceAsync(AddPetServiceDTO addPetService)
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
            // Check for required fields
            if (string.IsNullOrWhiteSpace(addPetService.Duration))
            {
                return Result.Failures(new List<Error> { PetServiceErrorMessage.FieldIsEmpty("Duration") });
            }
            if (addPetService.StaffQuantity <= 0)
            {
                return Result.Failures(new List<Error> { PetServiceErrorMessage.FieldIsEmpty("StaffQuantity") });
            }
            // Set default values
            var petService = new PetService
            {
                PetServiceCategoryId = Guid.NewGuid(),
                BasePrice = addPetService.BasePrice,
                Duration = addPetService.Duration,
                ImageUrl = addPetService.ImageUrl,
                StaffQuantity = addPetService.StaffQuantity,
                AvailableFrom = addPetService.AvailableFrom,
                AvailableTo = addPetService.AvailableTo,
                TravelCost = addPetService.TravelCost,
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false,
                OrderItems = new List<OrderItem>(),
                ModifiedDate = DateTime.UtcNow
            };

            // Create the service
            var createResult = await _unitOfWork.PetServiceRepository.CreateServiceAsync(petService);
            if (createResult == null)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceNotCreated());
            }

            return Result.SuccessWithObject(petService);
        }

        public async Task<Result> GetAllPetServicesAsync()
        {
            var petServices = await _unitOfWork.PetServiceRepository.GetAllServicesAsync();
            return Result.SuccessWithObject(petServices);
        }

        public async Task<Result> GetPetServiceByIdAsync(Guid id)
        {
            var petService = await _unitOfWork.PetServiceRepository.GetServiceByIdAsync(id);
            if (petService == null)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceNotExist());
            }

            return Result.SuccessWithObject(petService);
        }

        public async Task<Result> UpdatePetServiceAsync(Guid id, AddPetServiceDTO addPetService)
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
            var existingPetService = await _unitOfWork.PetServiceRepository.GetServiceByIdAsync(id);
            if (existingPetService == null)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceNotExist());
            }
            // Update the properties
            existingPetService.BasePrice = addPetService.BasePrice;
            existingPetService.Duration = addPetService.Duration;
            existingPetService.ImageUrl = addPetService.ImageUrl;
            existingPetService.StaffQuantity = addPetService.StaffQuantity;
            existingPetService.AvailableFrom = addPetService.AvailableFrom;
            existingPetService.AvailableTo = addPetService.AvailableTo;
            existingPetService.TravelCost = addPetService.TravelCost;
            existingPetService.ModifiedDate = DateTime.UtcNow;

            // Update the service
            var updateResult = await _unitOfWork.PetServiceRepository.UpdateServiceAsync(existingPetService);

            if (updateResult == 0)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceNotUpdated());
            }

            return Result.SuccessWithObject(updateResult);
        }

        public async Task<Result> DeletePetServiceAsync(Guid id)
        {
            var deleteResult = await _unitOfWork.PetServiceRepository.DeleteServiceAsync(id);
            if (deleteResult == 0)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceNotDeleted());
            }

            return Result.Success();
        }
    }
}

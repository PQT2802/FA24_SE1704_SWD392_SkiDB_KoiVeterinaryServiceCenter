﻿using Azure.Core;
using FluentValidation;
using KVSC.Application.Common.Validator.PetServiceCategory;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.DTOs.PetServiceCategory.AddPetServiceCategroy;
using KVSC.Infrastructure.DTOs.PetServiceCategory.GetPetServiceCategory;
using KVSC.Infrastructure.DTOs.PetServiceCategory.UpdatePetServiceCategory;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class PetServiceCategoryService : IPetServiceCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<AddPetServiceCategoryRequest> _petServiceCategoryValidator;
        private readonly IValidator<UpdatePetServiceCategoryRequest> _updatePetServiceCategoryValidator;

        public PetServiceCategoryService(IUnitOfWork unitOfWork, IValidator<AddPetServiceCategoryRequest> petServiceCategoryValidator, IValidator<UpdatePetServiceCategoryRequest> updatePetServiceCategoryValidator)
        {
            _unitOfWork = unitOfWork;
            _petServiceCategoryValidator = petServiceCategoryValidator;
            _updatePetServiceCategoryValidator = updatePetServiceCategoryValidator;
        }

        public async Task<Result> CreatePetServiceCategoryAsync(AddPetServiceCategoryRequest addPetServiceCategory)
        {
            // Validate the input
            var validationResult = await _petServiceCategoryValidator.ValidateAsync(addPetServiceCategory);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            var petServiceCategory = new PetServiceCategory
            {
                Name = addPetServiceCategory.Name,
                Description = addPetServiceCategory.Description,
                ServiceType = addPetServiceCategory.ServiceType,
                ApplicableTo = addPetServiceCategory.ApplicableTo,
                IsOnline = addPetServiceCategory.IsOnline,
            };

            // Create the category
            var createResult = await _unitOfWork.PetServiceCategoryRepository.CreateAsync(petServiceCategory);
            if (createResult == null)
            {
                return Result.Failure(PetServiceCategoryErrorMessage.PetServiceCategoryNotCreated());
            }
            var response = new CreateResponse { Id = petServiceCategory.Id };

            return Result.SuccessWithObject(response);
        }

        public async Task<Result> GetAllPetServiceCategoriesAsync()
        {
            var petServiceCategories = await _unitOfWork.PetServiceCategoryRepository.GetAllAsync();
            var response = petServiceCategories.Select(category => new GetPetServiceCategoryResponse
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                ServiceType = category.ServiceType,
                ApplicableTo = category.ApplicableTo,
                IsOnline = category.IsOnline,
            }).ToList();

            return Result.SuccessWithObject(response);
        }

        public async Task<Result> GetPetServiceCategoryByIdAsync(Guid Id)
        {
            var petServiceCategory = await _unitOfWork.PetServiceCategoryRepository.GetByIdAsync(Id);
            if (petServiceCategory == null)
            {
                return Result.Failure(PetServiceCategoryErrorMessage.PetServiceCategoryNotFound());
            }
            var response = new GetPetServiceCategoryResponse
            {
                Id = petServiceCategory.Id,
                Name = petServiceCategory.Name,
                Description = petServiceCategory.Description,
                ServiceType = petServiceCategory.ServiceType,
                ApplicableTo = petServiceCategory.ApplicableTo,
                IsOnline = petServiceCategory.IsOnline,
            };

            return Result.SuccessWithObject(response);
        }

        public async Task<Result> UpdatePetServiceCategoryAsync(UpdatePetServiceCategoryRequest updatePetServiceCategoryRequest)
        {
            var validationResult = await _updatePetServiceCategoryValidator.ValidateAsync(updatePetServiceCategoryRequest);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            var existingPetServiceCategory = await _unitOfWork.PetServiceCategoryRepository.GetByIdAsync(updatePetServiceCategoryRequest.Id);
            if (existingPetServiceCategory == null)
            {
                return Result.Failure(PetServiceCategoryErrorMessage.PetServiceCategoryNotFound());
            }

            existingPetServiceCategory.Name = updatePetServiceCategoryRequest.Name;
            existingPetServiceCategory.Description = updatePetServiceCategoryRequest.Description;
            existingPetServiceCategory.ServiceType = updatePetServiceCategoryRequest.ServiceType;
            existingPetServiceCategory.ApplicableTo = updatePetServiceCategoryRequest.ApplicableTo;
            existingPetServiceCategory.IsOnline = updatePetServiceCategoryRequest.IsOnline;
            // Update the category
            var updateResult = await _unitOfWork.PetServiceCategoryRepository.UpdateAsync(existingPetServiceCategory);
            if (updateResult == 0)
            {
                return Result.Failure(PetServiceCategoryErrorMessage.PetServiceCategoryUpdateFailed());
            }

            var response = new CreateResponse { Id = existingPetServiceCategory.Id };

            return Result.SuccessWithObject(response);
        }

        public async Task<Result> DeletePetServiceCategoryAsync(Guid id)
        {
            var existingPetServiceCategory = await _unitOfWork.PetServiceCategoryRepository.GetByIdAsync(id);
            if (existingPetServiceCategory == null)
            {
                return Result.Failure(PetServiceCategoryErrorMessage.PetServiceCategoryNotFound());
            }
            var countPetService = await _unitOfWork.PetServiceRepository.GetServiceByPetServiceCategoryIdAsync(id);
            if(countPetService > 0)
            {
                return Result.Failure(PetServiceCategoryErrorMessage.PetServiceCategoryInUse());
            }
            var deleteResult = await _unitOfWork.PetServiceCategoryRepository.DeleteAsync(id);
            if (deleteResult == 0)
            {
                return Result.Failure(PetServiceCategoryErrorMessage.PetServiceCategoryDeleteFailed());
            }

            return Result.SuccessWithObject(deleteResult);
        }

        
    }
}

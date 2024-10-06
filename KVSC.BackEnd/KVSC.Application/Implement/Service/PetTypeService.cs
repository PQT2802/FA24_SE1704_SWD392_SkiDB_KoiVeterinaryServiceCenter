using FluentValidation;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.AddPetType;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePetType;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class PetTypeService : IPetTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<AddPetTypeRequest> _addPetTypeValidator;
        private readonly IValidator<UpdatePetTypeRequest> _updatePetTypeValidator;


        public PetTypeService(IUnitOfWork unitOfWork,
            IValidator<AddPetTypeRequest> addPetTypeValidator,
            IValidator<UpdatePetTypeRequest> updatePetTypeValidator)
        {
            _unitOfWork = unitOfWork;
            _addPetTypeValidator = addPetTypeValidator;
            _updatePetTypeValidator = updatePetTypeValidator;
        }

        public async Task<Result> GetPetTypeByIdAsync(Guid id)
        {
            var petType = await _unitOfWork.PetTypeRepository.GetPetTypeByIdAsync(id);
            if (petType == null)
            {
                return Result.Failure(PetErrorMessage.PetTypeNotFound());
            }

            return Result.SuccessWithObject(petType);
        }

        public async Task<Result> GetAllPetTypesAsync()
        {
            var petTypes = await _unitOfWork.PetTypeRepository.GetAllPetTypesAsync();
            return Result.SuccessWithObject(petTypes);
        }

        public async Task<Result> CreatePetTypeAsync(AddPetTypeRequest addPetTypeDto)
        {
            // Validate input
            var validate = await _addPetTypeValidator.ValidateAsync(addPetTypeDto);
            if (!validate.IsValid)
            {
                var errors = validate.Errors.Select(e => (Error)e.CustomState).ToList();
                return Result.Failures(errors);
            }

            // Create PetType
            var petType = new PetType
            {
                Id = Guid.NewGuid(),
                GeneralType = addPetTypeDto.GeneralType.ToLower(),
                SpecificType = addPetTypeDto.SpecificType.ToLower(),
                PetHabitatId = addPetTypeDto.PetHabitatId
            };

            var createResult = await _unitOfWork.PetTypeRepository.CreatePetTypeAsync(petType);
            if (createResult == null)
            {
                return Result.Failure(PetErrorMessage.PetTypeCreateFailed());
            }
            
            return Result.SuccessWithObject(petType.Id);
        }

        public async Task<Result> UpdatePetTypeAsync(Guid id, UpdatePetTypeRequest updatePetTypeDto)
        {
            // Validate input
            var validate = await _updatePetTypeValidator.ValidateAsync(updatePetTypeDto);
            if (!validate.IsValid)
            {
                var errors = validate.Errors.Select(e => (Error)e.CustomState).ToList();
                return Result.Failures(errors);
            }

            // Get existing PetType
            var petType = await _unitOfWork.PetTypeRepository.GetPetTypeByIdAsync(id);
            if (petType == null)
            {
                return Result.Failure(PetErrorMessage.PetTypeNotFound());
            }

            petType.GeneralType = updatePetTypeDto.GeneralType.ToLower();
            petType.SpecificType = updatePetTypeDto.SpecificType.ToLower();
            petType.PetHabitatId = updatePetTypeDto.PetHabitatId;

            
            var updateResult = await _unitOfWork.PetTypeRepository.UpdatePetTypeAsync(petType);
            if (updateResult == 0)
            {
                return Result.Failure(PetErrorMessage.PetTypeUpdateFailed());
            }
            
            return Result.SuccessWithObject(updateResult);
        }

        public async Task<Result> DeletePetTypeAsync(Guid id)
        {
            var petType = await _unitOfWork.PetTypeRepository.GetPetTypeByIdAsync(id);
            if (petType == null)
            {
                return Result.Failure(PetErrorMessage.PetTypeNotFound());
            }

            var deleteResult = await _unitOfWork.PetTypeRepository.DeletePetTypeAsync(id);
            if (deleteResult == 0)
            {
                return Result.Failure(PetErrorMessage.PetTypeDeleteFailed());
            }
            
            return Result.SuccessWithObject(deleteResult);
        }
    }
}

using Azure.Core;
using FluentValidation;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.ComboService.GetComboServiceResponse;
using KVSC.Infrastructure.DTOs.ComboService.UpdateComboService;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Pet.AddComboService;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class ComboServiceService : IComboServiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<AddComboServiceRequest> _comboServiceValidator;
        private readonly IValidator<UpdateComboServiceRequest> _updateComboServiceValidator;
        public ComboServiceService(IUnitOfWork unitOfWork, IValidator<AddComboServiceRequest> comboServiceValidator)
        {
            _unitOfWork = unitOfWork;
            _comboServiceValidator = comboServiceValidator;
        }
        public async Task<Result> CreateComboServiceAsync(AddComboServiceRequest addComboService)
        {
            var validationResult = await _comboServiceValidator.ValidateAsync(addComboService);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                       .Select(e => (Error)e.CustomState)
                       .ToList();
                return Result.Failures(errors);
            }
            // Remove duplicate serviceIds and list 
            var distinctServiceIds = addComboService.ServiceIds.Distinct().ToList();

            // Check if there are at least 2 distinct services
            if (distinctServiceIds.Count < 2)
            {
                return Result.Failure(ComboServiceErrorMessage.ComboServiceInsufficientServices());
            }

            // Fetch existing services from database
            var existingServices = await _unitOfWork.PetServiceRepository
                                  .GetByIdsAsync(distinctServiceIds);

            // Check if all serviceIds exist in the database
            if (existingServices.Count != distinctServiceIds.Count)
            {
                return Result.Failure(ComboServiceErrorMessage.ComboServiceInvalidServiceIds());
            }

            var comboService = new ComboService
            {
                Name = addComboService.Name,
                DiscountPercentage = addComboService.DiscountPercentage,
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false,
                ComboServiceItems = addComboService.ServiceIds.Select(serviceId => new ComboServiceItem
                {
                    PetServiceId = serviceId
                }).ToList()
            };
            var createResult = await _unitOfWork.ComboServiceRepository.CreateAsync(comboService);
            if (createResult == null)
            {
                return Result.Failure(ComboServiceErrorMessage.ComboServiceNotCreated());
            }
            var response = new CreateResponse { Id = comboService.Id };
            return Result.SuccessWithObject(response);
        }

        public async Task<Result> GetComboServiceByIdAsync(Guid id)
        {
            var comboService = await _unitOfWork.ComboServiceRepository.GetComboByIdAsync(id);

            if (comboService == null || comboService.IsDeleted)
            {
                return Result.Failure(ComboServiceErrorMessage.ComboServiceNotFound());
            }

            var comboServiceResponse = new GetComboServiceResponse
            {
                Id = comboService.Id,
                Name = comboService.Name,
                DiscountPercentage = comboService.DiscountPercentage,
                ServiceIds = comboService.ComboServiceItems
                                         .Select(csi => csi.PetServiceId)
                                         .ToList(),
                ServiceName = comboService.ComboServiceItems
                                    .Select(csi => csi.PetService.Name)
                                    .ToList(),
                TotalPrice = comboService.TotalPrice
            };

            return Result.SuccessWithObject(comboServiceResponse);
        }
        public async Task<Result> GetAllComboServicesAsync()
        {
            var comboServices = await _unitOfWork.ComboServiceRepository.GetAllComboAsync();

            var comboServiceResponses = comboServices
                .Where(cs => !cs.IsDeleted) // Lọc bỏ các combo đã bị xóa
                .Select(cs => new GetComboServiceResponse
                {
                    Id = cs.Id,
                    Name = cs.Name,
                    DiscountPercentage = cs.DiscountPercentage,
                    ServiceIds = cs.ComboServiceItems
                                    .Select(csi => csi.PetServiceId)
                                    .ToList(),
                    ServiceName = cs.ComboServiceItems
                                    .Select(csi => csi.PetService.Name)
                                    .ToList(),
                    TotalPrice = cs.TotalPrice
                })
                .ToList();

            return Result.SuccessWithObject(comboServiceResponses);
        }

        public async Task<Result> UpdateComboServiceAsync(UpdateComboServiceRequest request)
        {
            var validationResult = await _updateComboServiceValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                       .Select(e => (Error)e.CustomState)
                       .ToList();
                return Result.Failures(errors);
            }
            var comboService = await _unitOfWork.ComboServiceRepository.GetComboByIdAsync(request.Id);
            if (comboService == null || comboService.IsDeleted)
            {
                return Result.Failure(ComboServiceErrorMessage.ComboServiceNotFound());
            }
            // Kiểm tra các serviceId có tồn tại không
            var distinctServiceIds = request.ServiceIds.Distinct().ToList();
            if (distinctServiceIds.Count < 2)
            {
                return Result.Failure(ComboServiceErrorMessage.ComboServiceInsufficientServices());
            }

            // Kiểm tra xem các serviceId có tồn tại không
            var existingServices = await _unitOfWork.PetServiceRepository.GetByIdsAsync(distinctServiceIds);
            if (existingServices.Count != distinctServiceIds.Count)
            {
                return Result.Failure(ComboServiceErrorMessage.ComboServiceInvalidServiceIds());
            }

            comboService.Name = request.Name;
            comboService.DiscountPercentage = request.DiscountPercentage;
            comboService.ModifiedDate = DateTime.UtcNow;
            // Xóa các ComboServiceItem không còn nằm trong danh sách distinctServiceIds
            var itemsToRemove = comboService.ComboServiceItems
                .Where(item => !distinctServiceIds.Contains(item.PetServiceId))
                .ToList();
            foreach (var item in itemsToRemove)
            {
                comboService.ComboServiceItems.Remove(item);
            }
            // Thêm các ComboServiceItem mới từ distinctServiceIds
            foreach (var serviceId in distinctServiceIds)
            {
                // Kiểm tra xem đã tồn tại chưa
                if (!comboService.ComboServiceItems.Any(item => item.PetServiceId == serviceId))
                {
                    comboService.ComboServiceItems.Add(new ComboServiceItem
                    {
                        PetServiceId = serviceId
                    });
                }
            }

            var updateResult = await _unitOfWork.ComboServiceRepository.UpdateAsync(comboService);
            if (updateResult == 0)
            {
                return Result.Failure(ComboServiceErrorMessage.ComboServiceUpdateFailed());
            }

            var response = new CreateResponse { Id = comboService.Id };
            return Result.SuccessWithObject(response);
        }

        public async Task<Result> DeleteComboServiceAsync(Guid id)
        {
            var comboService = await _unitOfWork.ComboServiceRepository.GetByIdAsync(id);
            if (comboService == null || comboService.IsDeleted)
            {
                return Result.Failure(ComboServiceErrorMessage.ComboServiceNotFound());
            }

            comboService.IsDeleted = true;
            var deleteResult = await _unitOfWork.ComboServiceRepository.UpdateAsync(comboService);
            if (deleteResult == 0)
            {
                return Result.Failure(ComboServiceErrorMessage.ComboServiceDeleteFailed());
            }

            return Result.SuccessWithObject(deleteResult);
        }
    }
}

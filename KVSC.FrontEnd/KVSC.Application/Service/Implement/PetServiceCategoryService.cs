using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.DeleteService;
using KVSC.Infrastructure.DTOs.ServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.AddServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.DeleteServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.UpdateServiceCategory;
using KVSC.Infrastructure.Repositories.Implement;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Implement
{
    public class PetServiceCategoryService : IPetServiceCategoryService
    {
        private readonly IPetServiceCategoryRepository _petServiceCategoryRepository;
        public PetServiceCategoryService(IPetServiceCategoryRepository petServiceCategoryRepository)
        {
            _petServiceCategoryRepository = petServiceCategoryRepository;
        }

        public async Task<ResponseDto<KoiServiceCategory>> GetKoiServiceCategory()
        {
            var response = await _petServiceCategoryRepository.GetKoiServiceCategory();
            return response;
        } 
        public async Task<ResponseDto<KoiServiceCategoryList>> GetKoiServiceCategoryList()
        {
            var response = await _petServiceCategoryRepository.GetKoiServiceCategoryList();
            return response;
        }
        public async Task<ResponseDto<AddServiceCategoryResponse>> CreateCategoryAsync(AddServiceCategoryRequest request)
        {
            request.Name = string.IsNullOrWhiteSpace(request.Name) ? string.Empty : request.Name;
            request.Description = string.IsNullOrWhiteSpace(request.Description) ? string.Empty : request.Description;
            request.ServiceType = string.IsNullOrWhiteSpace(request.ServiceType) ? string.Empty : request.ServiceType;
            request.ApplicableTo = string.IsNullOrWhiteSpace(request.ApplicableTo) ? string.Empty : request.ApplicableTo;
            var response = await _petServiceCategoryRepository.CreateCategoryAsync(request);
            return response;
        }
        public async Task<ResponseDto<UpdateCategoryResponse>> UpdateCategory(UpdateCategoryRequest request)
        {
            request.Name = string.IsNullOrWhiteSpace(request.Name) ? string.Empty : request.Name;
            request.Description = string.IsNullOrWhiteSpace(request.Description) ? string.Empty : request.Description;
            request.ServiceType = string.IsNullOrWhiteSpace(request.ServiceType) ? string.Empty : request.ServiceType;
            request.ApplicableTo = string.IsNullOrWhiteSpace(request.ApplicableTo) ? string.Empty : request.ApplicableTo;
            var response = await _petServiceCategoryRepository.UpdateCategory(request);
            return response;
        }

        public async Task<ResponseDto<DeleteServiceCategoryResponse>> DeletePetService(DeleteServiceCategoryRequest request)
        {
            var response = await _petServiceCategoryRepository.DeleteServiceCategory(request);
            return response;
        }
    }
}

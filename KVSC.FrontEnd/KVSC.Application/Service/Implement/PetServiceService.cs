using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.AddService;
using KVSC.Infrastructure.DTOs.Service.DeleteService;
using KVSC.Infrastructure.DTOs.Service.UpdateService;
using KVSC.Infrastructure.Repositories.Implement;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetServiceDto = KVSC.Infrastructure.DTOs.Service.ServiceDetail.PetServiceDto;

namespace KVSC.Application.Service.Implement
{
    public class PetServiceService : IPetServiceService
    {
        private readonly IPetServiceRepository _petServiceRepository;
        public PetServiceService(IPetServiceRepository petServiceRepository)
        {
            _petServiceRepository = petServiceRepository;
        }

        public async Task<ResponseDto<AddServiceResponse>> AddPetService(AddServiceRequest request)
        {
            request.Name = string.IsNullOrWhiteSpace(request.Name) ? string.Empty : request.Name;
            request.Duration = string.IsNullOrWhiteSpace(request.Duration) ? string.Empty : request.Duration;
            request.ImageUrl = string.IsNullOrWhiteSpace(request.ImageUrl) ? string.Empty : request.ImageUrl;
            var response = await _petServiceRepository.AddPetService(request);
            return response;
        }
        public async Task<ResponseDto<UpdateServiceResponse>> UpdatePetService(UpdateServiceRequest request)
        {
            request.Name = string.IsNullOrWhiteSpace(request.Name) ? string.Empty : request.Name;
            request.Duration = string.IsNullOrWhiteSpace(request.Duration) ? string.Empty : request.Duration;
            request.ImageUrl = string.IsNullOrWhiteSpace(request.ImageUrl) ? string.Empty : request.ImageUrl;
            var response = await _petServiceRepository.UpdatePetService(request);
            return response;
        }
        public async Task<ResponseDto<DeleteServiceResponse>> DeletePetService(DeleteServiceRequest request)
        {
            var response = await _petServiceRepository.DeletePetService(request);
            return response;
        }

        public async Task<ResponseDto<KoiServiceList>> GetKoiServiceList()
        {
            var response = await _petServiceRepository.GetKoiServiceList();
            return response;
        }
        
        public async Task<ResponseDto<PetServiceDto>> GetPetServiceByIdAsync(Guid id)
        {
            return await _petServiceRepository.GetPetServiceByIdAsync(id);
        }
    }
}

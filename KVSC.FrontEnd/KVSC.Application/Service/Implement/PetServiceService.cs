using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.AddService;
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
            var response = await _petServiceRepository.AddPetService(request);
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

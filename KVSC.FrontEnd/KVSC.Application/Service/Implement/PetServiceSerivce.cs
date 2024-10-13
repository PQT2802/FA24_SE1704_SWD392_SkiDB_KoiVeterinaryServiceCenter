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

namespace KVSC.Application.Service.Implement
{
    public class PetServiceSerivce : IPetServiceSerivce
    {
        private readonly IPetServiceRepository _petServiceRepository;
        public PetServiceSerivce(IPetServiceRepository petServiceRepository)
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
    }
}

using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Service.AddService;
using PetServiceDto = KVSC.Infrastructure.DTOs.Service.ServiceDetail.PetServiceDto;

namespace KVSC.Application.Service.Interface
{
    public interface IPetServiceService
    {
        Task<ResponseDto<KoiServiceList>> GetKoiServiceList();
        Task<ResponseDto<AddServiceResponse>> AddPetService(AddServiceRequest request);
        
        Task<ResponseDto<PetServiceDto>> GetPetServiceByIdAsync(Guid id);

    }
}

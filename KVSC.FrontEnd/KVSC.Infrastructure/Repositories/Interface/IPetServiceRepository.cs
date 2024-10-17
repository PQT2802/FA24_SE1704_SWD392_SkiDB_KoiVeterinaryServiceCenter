using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.AddService;
using KVSC.Infrastructure.DTOs.Service.DeleteService;
using KVSC.Infrastructure.DTOs.Service.UpdateService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetServiceDto = KVSC.Infrastructure.DTOs.Service.ServiceDetail.PetServiceDto;

namespace KVSC.Infrastructure.Repositories.Interface
{
    public interface IPetServiceRepository
    {
        Task<ResponseDto<KoiServiceList>> GetKoiServiceList();
        Task<ResponseDto<AddServiceResponse>> AddPetService(AddServiceRequest request);
        Task<ResponseDto<UpdateServiceResponse>> UpdatePetService(UpdateServiceRequest request);
        Task<ResponseDto<DeleteServiceResponse>> DeletePetService(DeleteServiceRequest request);
        
        Task<ResponseDto<PetServiceDto>> GetPetServiceByIdAsync(Guid id);

    }
}


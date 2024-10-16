using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Service.AddService;
using KVSC.Infrastructure.DTOs.Service.UpdateService;
using KVSC.Infrastructure.DTOs.Service.DeleteService;

namespace KVSC.Application.Service.Interface
{
    public interface IPetServiceSerivce
    {
        Task<ResponseDto<KoiServiceList>> GetKoiServiceList();
        Task<ResponseDto<AddServiceResponse>> AddPetService(AddServiceRequest request);
        Task<ResponseDto<UpdateServiceResponse>> UpdatePetService(UpdateServiceRequest request);
        Task<ResponseDto<DeleteServiceResponse>> DeletePetService(DeleteServiceRequest request);
    }
}

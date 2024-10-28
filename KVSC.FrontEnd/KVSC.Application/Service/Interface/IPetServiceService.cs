using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Service.AddService;
using PetServiceDto = KVSC.Infrastructure.DTOs.Service.ServiceDetail.PetServiceDto;
using KVSC.Infrastructure.DTOs.Service.UpdateService;
using KVSC.Infrastructure.DTOs.Service.DeleteService;
using KVSC.Infrastructure.DTOs.Service.GetServiceDetail;
using Microsoft.AspNetCore.Http;

namespace KVSC.Application.Service.Interface
{
    public interface IPetServiceService
    {
        Task<ResponseDto<KoiServiceList>> GetKoiServiceList();
        Task<ResponseDto<AddServiceResponse>> AddPetService(AddServiceRequest request, IFormFile imageFile);
        
        Task<ResponseDto<PetServiceDto>> GetPetServiceByIdAsync(Guid id);

        Task<ResponseDto<UpdateServiceResponse>> UpdatePetService(UpdateServiceRequest request, IFormFile imageFile);
        Task<ResponseDto<DeleteServiceResponse>> DeletePetService(DeleteServiceRequest request);
        Task<ResponseDto<GetPetServiceResponse>> GetPetServiceDetail(Guid id);
    }
}

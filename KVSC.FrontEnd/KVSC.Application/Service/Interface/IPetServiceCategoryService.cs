using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.ServiceCategory;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.ServiceCategory.AddServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.UpdateServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.DeleteServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.GetServiceCategory;

namespace KVSC.Application.Service.Interface
{
    public interface IPetServiceCategoryService
    {
        Task<ResponseDto<KoiServiceCategory>> GetKoiServiceCategory();
        Task<ResponseDto<KoiServiceCategoryList>> GetKoiServiceCategoryList();
        Task<ResponseDto<AddServiceCategoryResponse>> CreateCategoryAsync(AddServiceCategoryRequest request);
        Task<ResponseDto<UpdateCategoryResponse>> UpdateCategory(UpdateCategoryRequest request);
        Task<ResponseDto<DeleteServiceCategoryResponse>> DeletePetService(DeleteServiceCategoryRequest request);
        Task<ResponseDto<GetPetServiceCategoryResponse>> GetPetServiceCategoryDetail(Guid id);
    }
}

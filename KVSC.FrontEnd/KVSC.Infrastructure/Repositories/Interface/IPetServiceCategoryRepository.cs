using KVSC.Infrastructure.DTOs.Service.AddService;
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

namespace KVSC.Infrastructure.Repositories.Interface
{
    public interface IPetServiceCategoryRepository
    {
        Task<ResponseDto<KoiServiceCategoryList>> GetKoiServiceCategoryList();
        Task<ResponseDto<KoiServiceCategory>> GetKoiServiceCategory();
        Task<ResponseDto<AddServiceCategoryResponse>> CreateCategoryAsync(AddServiceCategoryRequest request);
        Task<ResponseDto<UpdateCategoryResponse>> UpdateCategory(UpdateCategoryRequest request);
        Task<ResponseDto<DeleteServiceCategoryResponse>> DeleteServiceCategory(DeleteServiceCategoryRequest request);
    }
}

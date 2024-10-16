using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Interface
{
    public interface IPetServiceCategoryService
    {
        Task<ResponseDto<KoiServiceCategory>> GetKoiServiceCategory();
        Task<ResponseDto<KoiServiceCategoryList>> GetKoiServiceCategoryList();
    }
}

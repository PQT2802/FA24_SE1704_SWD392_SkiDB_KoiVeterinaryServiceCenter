using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Implement
{
    public class PetServiceCategoryService : IPetServiceCategoryService
    {
        private readonly IPetServiceCategoryRepository _petServiceCategoryRepository;
        public PetServiceCategoryService(IPetServiceCategoryRepository petServiceCategoryRepository)
        {
            _petServiceCategoryRepository = petServiceCategoryRepository;
        }

        public async Task<ResponseDto<KoiServiceCategory>> GetKoiServiceCategory()
        {
            var response = await _petServiceCategoryRepository.GetKoiServiceCategory();
            return response;
        } 
        public async Task<ResponseDto<KoiServiceCategoryList>> GetKoiServiceCategoryList()
        {
            var response = await _petServiceCategoryRepository.GetKoiServiceCategoryList();
            return response;
        }
    }
}

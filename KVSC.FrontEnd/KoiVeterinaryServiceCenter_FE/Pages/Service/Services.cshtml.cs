using KVSC.Application.Service.Implement;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service.ServiceDetail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.Service
{
    public class ServicesModel : PageModel
    {
        private readonly IPetServiceService _petServiceService;
        private readonly IPetServiceCategoryService _petServiceCategoryService;

        public ServicesModel(IPetServiceService petServiceService, IPetServiceCategoryService petServiceCategoryService)
        {
            _petServiceService = petServiceService;
            _petServiceCategoryService = petServiceCategoryService;
        }

        [BindProperty]
        public KoiServiceList KoiServiceList { get; set; } = default!;

        [BindProperty]
        public KoiServiceCategoryList KoiServiceCategoryList { get; set; } = default!;

        public async Task OnGetAsync()
        {
            var result = await _petServiceService.GetKoiServiceList();
            var categoryResult = await _petServiceCategoryService.GetKoiServiceCategoryList();
            if (result.IsSuccess)
            {
                KoiServiceList = result.Data ?? new KoiServiceList();
            }
            else
            {
                KoiServiceList = new KoiServiceList
                {
                    Extensions = new Extensions<List<Data>> { Data = new List<Data>() }
                };
            }

            if (categoryResult.IsSuccess)
            {
                KoiServiceCategoryList = categoryResult.Data ?? new KoiServiceCategoryList();
            }
            else
            {
                KoiServiceCategoryList = new KoiServiceCategoryList
                {
                    Extensions = new Extensions<List<DataKoiServiceCategory>> { Data = new List<DataKoiServiceCategory>() }
                };
            }
        }
    }
}

using KVSC.Application.Service.Implement;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Service.GetServiceDetail;
using KVSC.Infrastructure.DTOs.ServiceCategory.GetServiceCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Admin
{
    public class PetServiceCategoryDetailModel : PageModel
    {
        private readonly IPetServiceCategoryService _petServiceCategoryService;
        [BindProperty]
        public GetPetServiceCategoryResponse PetServiceCategory { get; set; } = new();
        public PetServiceCategoryDetailModel(IPetServiceCategoryService petServiceCategoryService)
        {
            _petServiceCategoryService = petServiceCategoryService;
        }
        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            var result = await _petServiceCategoryService.GetPetServiceCategoryDetail(id);
            if (result.IsSuccess)
            {
                PetServiceCategory = result.Data ?? new GetPetServiceCategoryResponse();
            }
            else
            {
                PetServiceCategory = new GetPetServiceCategoryResponse();
            }
            if (PetServiceCategory == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }
    }
}


using KVSC.Application.Service.Implement;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Service.GetServiceDetail;
using KVSC.Infrastructure.DTOs.ServiceCategory.GetServiceCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Admin
{
    public class PetServiceDetailModel : PageModel
    {
        private readonly IPetServiceService _petServiceSerivce;

        [BindProperty]
        public GetPetServiceResponse PetService { get; set; } = new();

        public PetServiceDetailModel(IPetServiceService petServiceSerivce)
        {
            _petServiceSerivce = petServiceSerivce;
        }

        public async Task<IActionResult> OnGetAsync(GetPetServiceCategoryRequest request)
        {
            var result = await _petServiceSerivce.GetPetServiceDetail(request.Id);
            if (result.IsSuccess)
            {
                PetService = result.Data ?? new GetPetServiceResponse();
            }else
            {
                PetService = new GetPetServiceResponse();
            }
            if (PetService == null)
            {
                return RedirectToPage("/Error"); 
            }
            return Page();
        }
    }
}

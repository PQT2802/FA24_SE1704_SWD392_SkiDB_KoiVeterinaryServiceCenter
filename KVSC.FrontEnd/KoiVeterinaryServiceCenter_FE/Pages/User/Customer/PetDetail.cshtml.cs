using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Pet.GetPet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Customer
{
    public class PetDetailModel : PageModel
    {
        private readonly IPetBusinessService _petBusinessService;

        [BindProperty]
        public GetPetResponse PetDetail { get; set; } = new();

        public PetDetailModel(IPetBusinessService petBusinessService)
        {
            _petBusinessService = petBusinessService;
        }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            var result = await _petBusinessService.GetPetDetail(id);
            if (result.IsSuccess)
            {
                PetDetail = result.Data ?? new GetPetResponse();
            }
            else
            {
                PetDetail = new GetPetResponse();
            }
            if (PetDetail == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }
    }
}

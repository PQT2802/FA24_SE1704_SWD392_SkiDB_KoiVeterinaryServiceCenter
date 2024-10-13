using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.AddService;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Admin
{
    public class ServicesModel : PageModel
    {
        private readonly IPetServiceSerivce _petServiceSerivce;

        [BindProperty]
        public KoiServiceList KoiServiceList { get; set; }
        [BindProperty]
        public AddServiceRequest AddServiceRequest { get; set; }

        public ServicesModel(IPetServiceSerivce petServiceSerivce)
        {
            _petServiceSerivce = petServiceSerivce;
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var result = await _petServiceSerivce.AddPetService(AddServiceRequest);
            if (result.IsSuccess)
            {
                // Redirect or show success message after successful addition
                return RedirectToPage("/User/Admin/Services");
            }

            // Handle error case if needed
            return Page();
        }

        public async Task OnGetAsync()
        {
            var result = await _petServiceSerivce.GetKoiServiceList();
            if (result.IsSuccess)
            {
            
            KoiServiceList = result.Data;
            }
            else
            {
                // Handle the failure scenario (e.g., display an error message)
                KoiServiceList = new KoiServiceList
                {
                    Extensions = new Extensions<List<Data>> { Data = new List<Data>() }
                };
            }
        }
    }
}
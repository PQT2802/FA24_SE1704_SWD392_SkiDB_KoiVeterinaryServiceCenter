using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Admin
{
    public class ServicesListModel : PageModel
    {
        private readonly IPetServiceSerivce _petServiceSerivce;
        public ServicesListModel(IPetServiceSerivce petServiceSerivce) { _petServiceSerivce = petServiceSerivce; }
        public List<PetService> PetServices { get; set; }

        public async void OnGet()
        {
            PetServices = await _petServiceSerivce.GetAllPetServicesAsync();
        }
    }
}

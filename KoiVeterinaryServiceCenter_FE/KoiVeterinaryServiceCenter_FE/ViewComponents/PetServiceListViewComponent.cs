using KVSC.Application.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class PetServiceListViewComponent : ViewComponent
    {
        private readonly IPetServiceSerivce _petServiceSerivce;
        public PetServiceListViewComponent(IPetServiceSerivce petServiceSerivce) 
        {
            _petServiceSerivce = petServiceSerivce;
        }
        public async Task<IViewComponentResult> InvokeAsync(int petCategoryId)
        {
            var services = await _petServiceSerivce.GetPetServicesAsync(petCategoryId);
            return View(services);
        }
    }
}

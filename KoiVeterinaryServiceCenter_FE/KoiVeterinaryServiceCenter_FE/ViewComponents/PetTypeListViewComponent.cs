using KVSC.Application.Service.Interface;
using Microsoft.AspNetCore.Mvc;
namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class PetTypeListViewComponent : ViewComponent
    {
        private readonly IPetService _petService;
        public PetTypeListViewComponent(IPetService petService) 
        { 
            _petService = petService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _petService.GetPetTypeAsync();
            return View(data);
        }
    }
}

using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Service;
using Microsoft.AspNetCore.Mvc;

namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class PetServiceCategoryListViewComponent : ViewComponent
    {
        private readonly IPetServiceSerivce _petServiceSerivce;
        public PetServiceCategoryListViewComponent(IPetServiceSerivce petServiceSerivce) 
        {
            _petServiceSerivce = petServiceSerivce;
        }
        public async Task<IViewComponentResult> InvokeAsync(int petTypeId)
        {
           
            var cate = await _petServiceSerivce.GetPetServiceCategoriesAsync(petTypeId);
            return View(cate);
        }
    }
}

using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class ServiceTopViewComponent : ViewComponent
    {
        private readonly IPetServiceSerivce _petServiceService;

        public ServiceTopViewComponent(IPetServiceSerivce petServiceService)
        {
            _petServiceService = petServiceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Fetch service list (you could limit it to 6 here)
            var serviceResponse = await _petServiceService.GetKoiServiceList();

            if (serviceResponse.IsSuccess && serviceResponse.Data != null)
            {
                var services = serviceResponse.Data.Extensions?.Data.Take(6).ToList();
                var model = new GenericTableViewModel
                {
                    Items = services.Cast<IPropertyNameProvider>().ToList(),
                    PropertyNames = services.FirstOrDefault()?.GetPropertyNames() ?? new List<string>(),
                    ListType = "TopServices"
                };

                return View(model);
            }

            // Handle error case
            return View(new GenericTableViewModel
            {
                Items = new List<IPropertyNameProvider>(),
                PropertyNames = new List<string>(),
                ListType = "TopServices"
            });
        }
    }
}

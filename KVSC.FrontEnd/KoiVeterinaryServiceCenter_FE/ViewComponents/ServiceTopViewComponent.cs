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
            // Fetch all pet services
            var result = await _petServiceService.GetKoiServiceList();

            if (result.IsSuccess && result.Data != null)
            {
                // Ensure that the data is a list or enumerable
                var services = result.Data.Extensions?.Data.Take(6).ToList();  // Assuming result.Data.Extensions.Data is a list or enumerable

                var model = new GenericTableViewModel
                {
                    Items = services.Cast<IPropertyNameProvider>().ToList(),
                    PropertyNames = services.FirstOrDefault()?.GetPropertyNames() ?? new List<string>(),
                    ListType = "TopServices"
                };

                return View(model);
            }

            // In case of failure, return an empty list
            return View(new GenericTableViewModel
            {
                Items = new List<IPropertyNameProvider>(),
                PropertyNames = new List<string>(),
                ListType = "TopServices"
            });
        }

    }
}
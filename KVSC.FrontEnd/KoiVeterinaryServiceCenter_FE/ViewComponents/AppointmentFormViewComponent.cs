using KVSC.Infrastructure.DTOs;
using Microsoft.AspNetCore.Mvc;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Service;

namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class AppointmentFormViewComponent : ViewComponent
    {
        private readonly IPetServiceService _petServiceService;

        public AppointmentFormViewComponent(IPetServiceService petServiceService)
        {
            _petServiceService = petServiceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Fetch necessary data for the form
            var petServiceResponse = await _petServiceService.GetKoiServiceList();

            var model = new AppointmentFormViewModel
            {
                Services = petServiceResponse.IsSuccess ? petServiceResponse.Data.Extensions?.Data : new List<Data>(),
                AppointmentDate = DateTime.Now, // Default date
            };

            return View(model); // This will render the view with the form
        }
    }


}

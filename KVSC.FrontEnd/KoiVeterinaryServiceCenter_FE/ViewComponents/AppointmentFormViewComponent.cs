using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using KoiServicesData = KVSC.Infrastructure.DTOs.Service.KoiServicesData;

namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class AppointmentFormViewComponent : ViewComponent
    {
        private readonly IAuthService _authService;
        private readonly IPetBusinessService _petBusinessService;
        private readonly IPetServiceService _petServiceService;
        private readonly IUserService _userService;
        private readonly IAppointmentService _appointmentService;



        public AppointmentFormViewComponent(IAuthService authService, IPetServiceService petServiceService,
            IPetBusinessService petBusinessService, IUserService userService, IAppointmentService appointmentService)
        {
            _authService = authService;
            _petServiceService = petServiceService;
            _petBusinessService = petBusinessService;
            _userService = userService;
            _appointmentService = appointmentService;
        }
        [BindProperty]
        public List<ErrorDetail> ErrorMessage { get; set; }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var accessToken = HttpContext.Session.GetString("Token");

            // Handle case where access token is missing
            if (string.IsNullOrEmpty(accessToken))
            {
                return View(new AppointmentFormViewModel
                {
                    CustomerName = "Unknown",
                    CustomerEmail = "Unknown",
                    CustomerPhone = "Unknown",
                    Pets = new List<PetData>(),
                    Services = new List<KoiServicesData>(),
                    Veterinarians = new List<VeterinarianInfo>(),
                });
            }

            // Get user info based on the access token
            var getResult = await _authService.GetUserInforByToken(accessToken);
            if (getResult.IsSuccess)
            {
                var userInfor = getResult.Data;
                var token = HttpContext.Session.GetString("Token");

                // Fetch pets by owner ID
                var petResponse = await _petBusinessService.GetPetsByOwnerIdAsync(token);
                var pets = petResponse.IsSuccess
                    ? petResponse.Data?.Extensions?.Data ?? new List<PetData>()
                    : new List<PetData>();

                // Fetch Koi Service List
                var serviceResponse = await _petServiceService.GetKoiServiceList();
                var services = serviceResponse.IsSuccess
                    ? serviceResponse.Data.Extensions.Data
                    : new List<KoiServicesData>();

                // Fetch Veterinarian List
                var vetResponse = await _userService.GetAllVeterinariansAsync();
                var veterinarians = vetResponse.IsSuccess
                    ? vetResponse.Data
                    : new List<VeterinarianInfo>();

                // Create the view model with user info, pets, services, and veterinarians
                var model = new AppointmentFormViewModel
                {
                    CustomerName = userInfor.Extensions.Data.UserName,
                    CustomerEmail = userInfor.Extensions.Data.Email,
                    CustomerPhone = userInfor.Extensions.Data.PhoneNumber ?? "Unknown",
                    Pets = pets,
                    Services = services,
                    Veterinarians = veterinarians,
                    AppointmentDate = DateTime.Now,
                };

                return View(model);
            }

            // Handle case where user info fetch fails
            return View(new AppointmentFormViewModel
            {
                CustomerName = "Unknown",
                CustomerEmail = "Unknown",
                CustomerPhone = "Unknown",
                Pets = new List<PetData>(),
                Services = new List<KoiServicesData>(),
                Veterinarians = new List<VeterinarianInfo>(),
            });
        }

        public async Task<IActionResult> BookAppointment(AppointmentFormViewModel model)
        {
            var appointmentRequest = new MakeAppointmentForServiceRequest
            {
                CustomerId = model.Id,
                PetId = model.SelectedPetId.HasValue ? model.SelectedPetId.Value : Guid.Empty,
                PetServiceId = model.SelectedServiceId.HasValue ? model.SelectedServiceId.Value : Guid.Empty,
                VeterinarianIds = model.SelectedVeterinarianId.HasValue ? new List<Guid> { model.SelectedVeterinarianId.Value } : null,
                AppointmentDate = model.AppointmentDate,
            };

            var result = await _appointmentService.MakeAppointmentAsync(appointmentRequest);

            if (result.IsSuccess)
            {
                return RedirectToAction("AppointmentSuccess");
            }

            // Bind the error messages
            model.ErrorMessage = result.Errors ?? new List<ErrorDetail>();

            // Re-fetch data to refill the form
            var accessToken = HttpContext.Session.GetString("Token");
            var userInfor = (await _authService.GetUserInforByToken(accessToken)).Data;
            var pets = (await _petBusinessService.GetPetsByOwnerIdAsync(accessToken)).Data.Extensions?.Data ?? new List<PetData>();
            var services = (await _petServiceService.GetKoiServiceList()).Data.Extensions?.Data ?? new List<KoiServicesData>();
            var veterinarians = (await _userService.GetAllVeterinariansAsync()).Data ?? new List<VeterinarianInfo>();

            // Return the form view with the refilled model and error messages
            var modelWithErrors = new AppointmentFormViewModel
            {
                CustomerName = userInfor.Extensions.Data.UserName,
                CustomerEmail = userInfor.Extensions.Data.Email,
                CustomerPhone = userInfor.Extensions.Data.PhoneNumber ?? "Unknown",
                Pets = pets,
                Services = services,
                Veterinarians = veterinarians,
                AppointmentDate = model.AppointmentDate,
                ErrorMessage = model.ErrorMessage
            };

            return View("AppointmentForm", modelWithErrors);
        }

    }

}

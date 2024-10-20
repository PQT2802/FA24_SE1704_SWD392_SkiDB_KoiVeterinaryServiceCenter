using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using Data = KVSC.Infrastructure.DTOs.Service.Data;

namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class AppointmentFormViewComponent : ViewComponent
    {
        private readonly IAuthService _authService;
        private readonly IPetBusinessService _petBusinessService;
        private readonly IPetServiceService _petServiceService;
        private readonly IUserService _userService;

        public AppointmentFormViewComponent(IAuthService authService, IPetServiceService petServiceService,
            IPetBusinessService petBusinessService, IUserService userService)
        {
            _authService = authService;
            _petServiceService = petServiceService;
            _petBusinessService = petBusinessService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Get access token from session
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
                    Services = new List<Data>(),
                    Veterinarians = new List<VeterinarianInfo>()
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
                    : new List<Data>();

                // Fetch Veterinarian List
                // Fetch veterinarian list
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
                    Veterinarians = veterinarians, // Add veterinarians to the view model
                    AppointmentDate = DateTime.Now
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
                Services = new List<Data>(),
                Veterinarians = new List<VeterinarianInfo>() // Empty veterinarians list
            });
        }
    }
}
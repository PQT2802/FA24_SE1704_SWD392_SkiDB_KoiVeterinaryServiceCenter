using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KoiServicesData = KVSC.Infrastructure.DTOs.Service.KoiServicesData;

namespace KoiVeterinaryServiceCenter_FE.Pages.Appointment
{
    public class AppointmentModel : PageModel
    {
        private readonly IAuthService _authService;
        private readonly IPetBusinessService _petBusinessService;
        private readonly IPetServiceService _petServiceService;
        private readonly IUserService _userService;
        private readonly IAppointmentService _appointmentService;

        public AppointmentModel(IAuthService authService, IPetServiceService petServiceService,
            IPetBusinessService petBusinessService, IUserService userService, IAppointmentService appointmentService)
        {
            _authService = authService;
            _petServiceService = petServiceService;
            _petBusinessService = petBusinessService;
            _userService = userService;
            _appointmentService = appointmentService;
        }

        [BindProperty]
        public AppointmentFormViewModel AppointmentForm { get; set; } = new AppointmentFormViewModel();

        public async Task<IActionResult> OnGetAsync()
        {
            var accessToken = HttpContext.Session.GetString("Token");

            if (string.IsNullOrEmpty(accessToken))
            {
                // Set default values in case no token is found
                AppointmentForm.CustomerName = "Unknown";
                AppointmentForm.CustomerEmail = "Unknown";
                AppointmentForm.CustomerPhone = "Unknown";
                AppointmentForm.Pets = new List<PetData>();
                AppointmentForm.Services = new List<KoiServicesData>();
                AppointmentForm.Veterinarians = new List<VeterinarianInfo>();
                return Page();
            }

            var userResult = await _authService.GetUserInforByToken(accessToken);
            if (userResult.IsSuccess)
            {
                var userInfor = userResult.Data;

                // Fetch pets by owner ID
                var petResponse = await _petBusinessService.GetPetsByOwnerIdAsync(accessToken);
                AppointmentForm.Pets = petResponse.IsSuccess ? petResponse.Data?.Extensions?.Data : new List<PetData>();

                // Fetch Koi Service List
                var serviceResponse = await _petServiceService.GetKoiServiceList();
                AppointmentForm.Services = serviceResponse.IsSuccess ? serviceResponse.Data.Extensions.Data : new List<KoiServicesData>();

                // Fetch Veterinarian List
                var vetResponse = await _userService.GetAllVeterinariansAsync();
                AppointmentForm.Veterinarians = vetResponse.IsSuccess ? vetResponse.Data : new List<VeterinarianInfo>();

                // Populate the form model
                AppointmentForm.CustomerName = userInfor.Extensions.Data.UserName;
                AppointmentForm.CustomerEmail = userInfor.Extensions.Data.Email;
                AppointmentForm.CustomerPhone = userInfor.Extensions.Data.PhoneNumber ?? "Unknown";
                AppointmentForm.AppointmentDate = DateTime.Now;

                return Page();
            }

            // Handle failure case
            AppointmentForm.CustomerName = "Unknown";
            AppointmentForm.CustomerEmail = "Unknown";
            AppointmentForm.CustomerPhone = "Unknown";
            AppointmentForm.Pets = new List<PetData>();
            AppointmentForm.Services = new List<KoiServicesData>();
            AppointmentForm.Veterinarians = new List<VeterinarianInfo>();

            return Page();
        }

        public async Task<IActionResult> OnPostBookAppointmentAsync()
        {
            if (!ModelState.IsValid)
            {
                // Re-fetch data to refill the form in case of validation errors
                await OnGetAsync();
                return Page();
            }

            var accessToken = HttpContext.Session.GetString("Token");

            var appointmentRequest = new MakeAppointmentForServiceRequest
            {
                CustomerId = AppointmentForm.,
                PetId = AppointmentForm.SelectedPetId.HasValue ? AppointmentForm.SelectedPetId.Value : Guid.Empty,
                PetServiceId = AppointmentForm.SelectedServiceId.HasValue ? AppointmentForm.SelectedServiceId.Value : Guid.Empty,
                VeterinarianIds = AppointmentForm.SelectedVeterinarianId.HasValue ? new List<Guid> { AppointmentForm.SelectedVeterinarianId.Value } : null,
                AppointmentDate = AppointmentForm.AppointmentDate,
            };

            var result = await _appointmentService.MakeAppointmentAsync(appointmentRequest);

            if (result.IsSuccess)
            {
                return RedirectToPage("AppointmentSuccess");
            }

            // Handle error, bind the error messages
            AppointmentForm.ErrorMessage = result.Errors ?? new List<ErrorDetail>();

            // Re-fetch the data to refill the form after error
            await OnGetAsync();

            return Page();
        }
    }
}

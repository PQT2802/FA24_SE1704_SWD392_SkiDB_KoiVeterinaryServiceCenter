using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;

namespace KoiVeterinaryServiceCenter_FE.Pages.Appointment
{
    public class AppointmentModel : PageModel
    {
        private readonly IAuthService _authService;
        private readonly IPetBusinessService _petBusinessService;
        private readonly IPetServiceService _petServiceService;
        private readonly IUserService _userService;
        public AppointmentModel(IAuthService authService, IPetServiceService petServiceService, IPetBusinessService petBusinessService, IUserService userService)
        {
            _authService = authService;
            _petServiceService = petServiceService;
            _petBusinessService = petBusinessService;
            _userService = userService;
        }
        [BindProperty]
        UserInfo UserInfo { get; set; }
        MakeAppointmentRequest MakeAppointmentRequest { get; set; }

        public async void OnGetAsync()
        {
            var accessToken = HttpContext.Session.GetString("Token");
            if (accessToken == null) 
            {

            }
            var getResult = await _authService.GetUserInforByToken(accessToken);
            if (getResult.IsSuccess)
            {
                 UserInfo = getResult.Data;

                // Fetch pets by owner ID
                var petResponse = await _petBusinessService.GetPetsByOwnerIdAsync(accessToken);

                var pets = petResponse.IsSuccess
                    ? petResponse.Data?.Extensions?.Data ?? new List<PetData>()
                    : new List<PetData>();

                // Fetch Koi Service List
                var serviceResponse = await _petServiceService.GetKoiServiceList();
                var services = serviceResponse.IsSuccess
                    ? serviceResponse.Data.Extensions.Data
                    : new List<KVSC.Infrastructure.DTOs.Service.Data>();
            }
            if(MakeAppointmentRequest.AppointmentDate != null)
            {
                var vets = await _userService.GetVetForAppoinment();
            }
        }

    }
}

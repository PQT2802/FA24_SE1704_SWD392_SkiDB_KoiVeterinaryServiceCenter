using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoiVeterinaryServiceCenter_FE.Pages.Appointment
{
    public class AppointmentModel : PageModel
    {
        private readonly IAuthService _authService;
        private readonly IPetBusinessService _petBusinessService;
        private readonly IPetServiceService _petServiceService;
        private readonly IUserService _userService;
        private readonly IScheduleService _scheduleService;

        public AppointmentModel(IAuthService authService, IPetServiceService petServiceService, IPetBusinessService petBusinessService, IUserService userService, IScheduleService scheduleService)
        {
            _authService = authService;
            _petServiceService = petServiceService;
            _petBusinessService = petBusinessService;
            _userService = userService;
            _scheduleService = scheduleService;
        }

        [BindProperty]
        public UserInfo UserInfo { get; set; } = new UserInfo();
        public List<KVSC.Infrastructure.DTOs.Service.Data> Services { get; set; } = new List<KVSC.Infrastructure.DTOs.Service.Data>();
        public List<PetData> Pets { get; private set; } = new List<PetData>();
        public List<GetVetIdData> Veterinarians { get; private set; } = new List<GetVetIdData>();

        public MakeAppointmentRequest MakeAppointmentRequest { get; set; }
        public bool IsAuthenticated { get; private set; }

        public async Task OnGetAsync()
        {
            var accessToken = HttpContext.Session.GetString("Token");
            IsAuthenticated = accessToken != null;

            if (!IsAuthenticated) return;

            // Fetch user information
            var getResult = await _authService.GetUserInforByToken(accessToken);
            if (getResult.IsSuccess)
            {
                UserInfo = getResult.Data;
                UserInfo.Extensions ??= new Extensions<Data>();

                var petResponse = await _petBusinessService.GetPetsByOwnerIdAsync(accessToken);
                Pets = petResponse.IsSuccess ? petResponse.Data?.Extensions?.Data ?? new List<PetData>() : new List<PetData>();

                var serviceResponse = await _petServiceService.GetKoiServiceList();
                Services = serviceResponse.IsSuccess ? serviceResponse.Data.Extensions.Data : new List<KVSC.Infrastructure.DTOs.Service.Data>();
            }
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OnPostFindAvailableVetsAsync(DateTime selectedDate)
        {
            var vets = await _scheduleService.GetAvailableVeterinariansByDateTime(selectedDate);
            Veterinarians = vets.IsSuccess ? vets.Data.Extensions.Data.Where(v => v.IsAvailable).ToList() : new List<GetVetIdData>();

            // Return the partial view with available veterinarians
            return Partial("_VeterinarianSelection", Veterinarians);
        }
    }
}

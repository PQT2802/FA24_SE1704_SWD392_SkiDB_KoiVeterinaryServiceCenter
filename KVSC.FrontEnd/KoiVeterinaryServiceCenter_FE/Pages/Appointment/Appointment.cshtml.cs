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
using System.Text.Json;

namespace KoiVeterinaryServiceCenter_FE.Pages.Appointment
{
    public class AppointmentModel : PageModel
    {
        private readonly IAuthService _authService;
        private readonly IPetBusinessService _petBusinessService;
        private readonly IPetServiceService _petServiceService;
        private readonly IUserService _userService;
        private readonly IScheduleService _scheduleService;
        private readonly IAppointmentService _appointmentService;

        public AppointmentModel(IAuthService authService, IPetServiceService petServiceService, IPetBusinessService petBusinessService, IUserService userService, IScheduleService scheduleService, IAppointmentService appointmentService)
        {
            _authService = authService;
            _petServiceService = petServiceService;
            _petBusinessService = petBusinessService;
            _userService = userService;
            _scheduleService = scheduleService;
            _appointmentService = appointmentService;
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

                var petResponse = await _petBusinessService.GetPetsByOwnerAsync(getResult.Data.Extensions.Data.UserId);
                Pets = petResponse.IsSuccess ? petResponse.Data?.Extensions?.Data ?? new List<PetData>() : new List<PetData>();

                var serviceResponse = await _petServiceService.GetKoiServiceList();
                Services = serviceResponse.IsSuccess ? serviceResponse.Data.Extensions.Data : new List<KVSC.Infrastructure.DTOs.Service.Data>();
            }
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OnPostFindAvailableVetsAsync(DateTime selectedDate,Guid serviceId)
        {           
            string formattedDate = selectedDate.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
            string encodedDate = Uri.EscapeDataString(formattedDate);          
            var vets = await _scheduleService.GetAvailableVeterinariansByDateTime(encodedDate,serviceId);          
            Veterinarians = vets.IsSuccess ? vets.Data.Extensions.Data.Where(v => v.IsAvailable).ToList() : new List<GetVetIdData>();         
            return Partial("_VeterinarianSelection", Veterinarians);
        }
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OnPostSubmitAppointmentAsync(Guid serviceId, DateTime appointmentDate, Guid petId, List<Guid>? vetIds)
        {
            // Reload Services to ensure they are available for the post request
            var serviceResponse = await _petServiceService.GetKoiServiceList();
            Services = serviceResponse.IsSuccess ? serviceResponse.Data.Extensions.Data : new List<KVSC.Infrastructure.DTOs.Service.Data>();

            var selectedService = Services.FirstOrDefault(s => s.Id == serviceId);
            if (selectedService == null)
            {
                TempData["ErrorMessage"] = "The selected service is invalid.";
                return Page();
            }
            var accessToken = HttpContext.Session.GetString("Token");
            var getResult = await _authService.GetUserInforByToken(accessToken);
            UserInfo = getResult.Data;
            UserInfo.Extensions ??= new Extensions<Data>();
            var requiredAmount = selectedService.BasePrice * 0.20m;
            if (UserInfo.Extensions.Data.Amount < requiredAmount)
            {
                TempData["ErrorMessage"] = "Insufficient balance. Please top up your wallet to book this appointment.";
                return Page();
            }

            MakeAppointmentRequest = new MakeAppointmentRequest
            {
                CustomerId = UserInfo.Extensions.Data.UserId,
                PetId = petId,
                PetServiceId = serviceId,
                VeterinarianIds = vetIds,
                AppointmentDate = appointmentDate
            };

            var result = await _appointmentService.MakeAppointmentAsync(MakeAppointmentRequest);
            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Appointment successfully booked!";
                //var successMessage = new ModalViewModel
                //{
                //    Type = "Success",
                //    Title = "Success",
                //    Message = "Appointment successfully booked!"
                //};
                //TempData["ModalMessage"] = JsonSerializer.Serialize(successMessage);
                
                
            }
            else
            {
                var errorDetail = result.Errors.FirstOrDefault(e => e.Code.Equals("Exist"));
                if (errorDetail != null)
                {
                    TempData["ErrorMessage"] = errorDetail.Description.ToString();
                }
                else
                {
                    TempData["ErrorMessage"] = "Failed to book appointment. Please try again.";
                }
                
            }

            return Page();
        }

    }
}

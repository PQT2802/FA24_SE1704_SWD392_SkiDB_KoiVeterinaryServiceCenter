using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.Service;
using Microsoft.AspNetCore.Mvc;

namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class AppointmentFormViewComponent : ViewComponent
{
    private readonly IAuthService _authService;
    private readonly IPetBusinessService _petBusinessService;
    private readonly IPetServiceService _petServiceService;

    public AppointmentFormViewComponent(IAuthService authService, IPetServiceService petServiceService, IPetBusinessService petBusinessService)
    {
        _authService = authService;
        _petServiceService = petServiceService;
        _petBusinessService = petBusinessService;
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
                Services = new List<Data>(), // Empty service list
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

            // Create the view model with user info, pets, and services
            var model = new AppointmentFormViewModel
            {
                CustomerName = userInfor.Extensions.Data.UserName,
                CustomerEmail = userInfor.Extensions.Data.Email,
                CustomerPhone = userInfor.Extensions.Data.PhoneNumber ?? "Unknown",
                Pets = pets,
                Services = services,
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
            Services = new List<Data>(), // Empty service list
        });
    }
}


}
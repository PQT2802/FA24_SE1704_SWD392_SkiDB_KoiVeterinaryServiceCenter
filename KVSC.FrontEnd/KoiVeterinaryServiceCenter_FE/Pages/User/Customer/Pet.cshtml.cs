using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.DTOs.Pet.DeletePet;
using System.IdentityModel.Tokens.Jwt;
using KVSC.Infrastructure.DTOs.User;
using Newtonsoft.Json.Linq;
using KVSC.Application.Service.Implement;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Product;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Customer
{
    public class PetModel : PageModel
    {
        private readonly IPetBusinessService _petService;

        [BindProperty]
        public PetList PetList { get; set; } = default!;

        [BindProperty]
        public AddPetRequest AddPetRequest { get; set; } = default!;

        [BindProperty]
        public UpdatePetRequest UpdatePetRequest { get; set; } = default!;

        public bool ShowModal { get; set; } = false;
        public Guid UserId { get; set; }
        public PetModel(IPetBusinessService petService)
        {
            _petService = petService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var token = HttpContext.Session.GetString("Token");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;

            if (!Guid.TryParse(userIdClaimString, out Guid userId))
            {
                ModelState.AddModelError(string.Empty, "Unable to decode userId from token..");
                return Page();
            }

            var result = await _petService.GetPetsByOwnerAsync(userId);

            if (result.IsSuccess)
            {
                PetList = result.Data ?? new PetList();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error fetching pet data");
            }

            UserId = userId;
            return Page();
        }

        public async Task<IActionResult> OnPostCreatePetAsync()
        {
            var token = HttpContext.Session.GetString("Token");
            if (string.IsNullOrEmpty(token))
            {
                return Redirect("/Account/SignIn");
            }
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;
            if (!Guid.TryParse(userIdClaimString, out var userId))
            {
                ModelState.AddModelError(string.Empty, "Unable to decode user id");
                return Page();
            }
            AddPetRequest.OwnerId = userId;
            var result = await _petService.AddPetAsync(AddPetRequest);

            if (result.IsSuccess)
            {
                return new JsonResult(new { isSuccess = true });
            }

            var errors = ProcessErrors(result.Errors);
            return new JsonResult(new { isSuccess = false, errors });
        }

        public async Task<IActionResult> OnPostUpdatePetAsync()
        {
            var token = HttpContext.Session.GetString("Token");
            if (string.IsNullOrEmpty(token))
            {
                return Redirect("/Account/SignIn");
            }

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;

            if (!Guid.TryParse(userIdClaimString, out var userId))
            {
                ModelState.AddModelError(string.Empty, "Unable to decode user id");
                return Page();
            }

            UpdatePetRequest.OwnerId = userId;
            var result = await _petService.UpdatePetAsync(UpdatePetRequest);

            if (result.IsSuccess)
            {
                return new JsonResult(new { isSuccess = true });
            }

            var errors = ProcessErrors(result.Errors);
            return new JsonResult(new { isSuccess = false, errors });
        }

        public async Task<IActionResult> OnPostDeletePetAsync(Guid Id)
        {
            var request = new DeletePetRequest { Id = Id };
            var result = await _petService.DeletePetAsync(request);

            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Pet deleted successfully.";
                TempData["AlertClass"] = "alert-success";
                return RedirectToPage("/User/Customer/Pet");
            }

            TempData["ErrorMessage"] = "Failed to delete pet: " + string.Join(", ", result.Errors.Select(e => e.Description));
            return RedirectToPage("/User/Customer/Pet");
        }

        private Dictionary<string, string> ProcessErrors(List<ErrorDetail>? errors)
        {
            var errorDictionary = new Dictionary<string, string>();

            if (errors != null)
            {
                foreach (var error in errors)
                {
                    switch (error.Code)
                    {
                        case "Pet.Empty":
                            if (error.Description.Contains("Name", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Name"] = error.Description;
                            else if (error.Description.Contains("Gender", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Gender"] = error.Description;
                            else if (error.Description.Contains("ImageUrl", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["ImageUrl"] = error.Description;
                            else if (error.Description.Contains("Color", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Color"] = error.Description;
                            else if (error.Description.Contains("Note", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Note"] = error.Description;
                            //else if (error.Description.Contains("LastHealthCheck", StringComparison.OrdinalIgnoreCase))
                            //    errorDictionary["LastHealthCheck"] = error.Description;
                            break;

                        case "Pet.InvalidValue":
                            if (error.Description.Contains("Age", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Age"] = error.Description;
                            else if (error.Description.Contains("Length", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Length"] = error.Description;
                            else if (error.Description.Contains("Weight", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Weight"] = error.Description;
                            else if (error.Description.Contains("Quantity", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Quantity"] = error.Description;
                            else if (error.Description.Contains("HealthStatus", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["HealthStatus"] = error.Description;
                            break;

                        default:
                            errorDictionary[string.Empty] = error.Description;
                            break;
                    }
                }
            }
            return errorDictionary;
        }
    }
}

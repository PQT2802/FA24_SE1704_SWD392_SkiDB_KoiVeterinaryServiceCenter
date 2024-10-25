using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.DTOs.Pet.DeletePet;
using System.IdentityModel.Tokens.Jwt;

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

        public PetModel(IPetBusinessService petService)
        {
            _petService = petService;
        }
        public async Task OnGetAsync()
        {
            
            var result = await _petService.GetPetList();
            if (result.IsSuccess)
            {
                PetList = result.Data;

                if (PetList.Extensions == null)
                {
                    PetList.Extensions = new Extensions<List<PetData>>
                    {
                        Data = new List<PetData>()
                    };
                }
            }
            else
            {
                PetList = new PetList
                {
                    Extensions = new Extensions<List<PetData>> { Data = new List<PetData>() }
                };
            }
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
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type =="userId")?.Value;
            if(!Guid.TryParse(userIdClaimString, out var userId))
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
                        //case "Pet.Empty":
                        //    break;

                        case "Pet.Positive":
                            if (error.Description.Contains("Quantity", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Quantity"] = error.Description;
                            break;
                        //case "Pet.Length":
                        //    break;

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

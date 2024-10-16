using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.DTOs.Pet.DeletePet;

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
                            if (error.Description.Contains("Name", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Name"] = error.Description;
                            else if (error.Description.Contains("Gender", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Gender"] = error.Description;
                            else if (error.Description.Contains("ImageUrl", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["ImageUrl"] = error.Description;
                            else if (error.Description.Contains("Color", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Color"] = error.Description;
                            break;

                        case "Pet.InvalidValue":
                            if (error.Description.Contains("Age", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Age"] = error.Description;
                            else if (error.Description.Contains("Length", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Length"] = error.Description;
                            else if (error.Description.Contains("Weight", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Weight"] = error.Description;
                            else if (error.Description.Contains("HealthStatus", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["HealthStatus"] = error.Description;
                            break;

                        case "Pet.InvalidDate":
                            if (error.Description.Contains("LastHealthCheck", System.StringComparison.OrdinalIgnoreCase))
                                errorDictionary["LastHealthCheck"] = error.Description;
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

using KVSC.Application.Service.Implement;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.ServiceCategory.AddServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.DeleteServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.UpdateServiceCategory;
using KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Admin
{
    public class ServiceCategoryModel : PageModel
    {
        private readonly IPetServiceCategoryService _petServiceCategoryService;

        [BindProperty]
        public KoiServiceCategoryList KoiServiceCategoryList { get; set; } = new();

        [BindProperty]
        public AddServiceCategoryRequest AddServiceCategoryRequest { get; set; } = default!;

        [BindProperty]
        public UpdateCategoryRequest UpdateCategoryRequest { get; set; } = default!;

        public bool ShowModal { get; set; } = false;

        public ServiceCategoryModel(IPetServiceCategoryService petServiceCategoryService)
        {
            _petServiceCategoryService = petServiceCategoryService;
        }


        public async Task OnGetAsync()
        {
            var result = await _petServiceCategoryService.GetKoiServiceCategoryList();
            if (result.IsSuccess)
            {
                KoiServiceCategoryList = result.Data ?? new KoiServiceCategoryList();
                
            }
            else
            {
                KoiServiceCategoryList = new KoiServiceCategoryList();
            }
        }
        public async Task<IActionResult> OnPostCreateCategoryAsync()
        {
            var result = await _petServiceCategoryService.CreateCategoryAsync(AddServiceCategoryRequest);

            if (result.IsSuccess)
            {
                return new JsonResult(new { isSuccess = true });
            }

            var errors = ProcessErrors(result.Errors);
            return new JsonResult(new { isSuccess = false, errors });
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
                        case "PetServiceCategory.Empty":
                            if (error.Description.Contains("Category name", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Name"] = error.Description;
                            else if (error.Description.Contains("Description", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Description"] = error.Description;
                            else if (error.Description.Contains("ServiceType", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["ServiceType"] = error.Description;
                            else if (error.Description.Contains("ApplicableTo", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["ApplicableTo"] = error.Description;
                            break;
                        default:
                            errorDictionary[string.Empty] = error.Description;
                            break;
                    }
                }
            }
            return errorDictionary;
        }
        public async Task<IActionResult> OnPostUpdateCategoryAsync()
        {
            var result = await _petServiceCategoryService.UpdateCategory(UpdateCategoryRequest);

            if (result.IsSuccess)
            {
                return new JsonResult(new { isSuccess = true });
            }

            var errors = ProcessErrors(result.Errors);
            return new JsonResult(new { isSuccess = false, errors });
        }
        public async Task<IActionResult> OnPostDeleteServiceCategoryAsync(Guid Id)
        {
            var request = new DeleteServiceCategoryRequest { Id = Id }; 
            var result = await _petServiceCategoryService.DeletePetService(request); 

            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Category deleted successfully."; 
                TempData["AlertClass"] = "alert-success";
                return RedirectToPage("/User/Admin/ServiceCategory"); 
            }

            TempData["ErrorMessage"] = "Failed to delete category: " + string.Join(", ", result.Errors.Select(e => e.Description)); 
            return RedirectToPage("/User/Admin/ServiceCategory"); 
        }
    }
}

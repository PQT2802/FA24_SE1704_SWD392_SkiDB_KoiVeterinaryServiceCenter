using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Service.ServiceDetail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.Service;

public class DetailsModel : PageModel
{
    private readonly IPetServiceService _petServiceService;

    public DetailsModel(IPetServiceService petServiceService)
    {
        _petServiceService = petServiceService;
    }

    public PetServiceDto ServiceDetails { get; set; }
    public string ErrorMessage { get; set; }

    public async Task<IActionResult> OnGetAsync(Guid id)
    {
        if (id == Guid.Empty)
        {
            return NotFound(); // Return 404 if the ID is invalid
        }

        // Fetch the service details based on the ID
        var result = await _petServiceService.GetPetServiceByIdAsync(id);

        if (result.IsSuccess)
        {
            ServiceDetails = result.Data;  // Ensure this is populated
            return Page();
        }
        else
        {
            ErrorMessage = result.Message;  // Set the error message if something goes wrong
            return Page();
        }
    }
}

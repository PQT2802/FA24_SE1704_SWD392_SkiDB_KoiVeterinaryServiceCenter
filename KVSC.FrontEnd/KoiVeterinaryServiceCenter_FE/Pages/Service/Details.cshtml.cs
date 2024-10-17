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
            // If no ID is provided, return a 404 or some error handling
            return NotFound();
        }

        // Fetch the service details based on the ID
        var result = await _petServiceService.GetPetServiceByIdAsync(id);

        if (result.IsSuccess)
        {
            ServiceDetails = result.Data;
            return Page(); // Return the page if successful
        }
        else
        {
            ErrorMessage = result.Message;
            return Page(); // Return the page even if there's an error
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.Services
{
    public class ServicesModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int SelectedPetTypeId { get; set; }
        [BindProperty(SupportsGet = true)]
        public int SelectedPetServiceCategoryId { get; set; }

        public void OnGet()
        {
            // No need for additional logic, as the ViewComponents handle data retrieval.
        }
    }
}

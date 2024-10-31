using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages
{
    public class ExampleModel : PageModel
    {
        public IActionResult OnGet()
        {
            try
            {
                // Cố tình gây lỗi
                throw new Exception("Error checking exception.");
            }
            catch (Exception)
            {
                return RedirectToPage("/Errors", new { code = 500 });
            }
        }
    }
}

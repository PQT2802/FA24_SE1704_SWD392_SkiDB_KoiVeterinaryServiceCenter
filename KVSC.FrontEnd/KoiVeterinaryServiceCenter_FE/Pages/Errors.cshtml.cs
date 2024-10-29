using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages
{
    public class ErrorsModel : PageModel
    {
        public int StatusCode { get; set; }

        public void OnGet(int? code)
        {
            StatusCode = code ?? 500;
        }
    }
}

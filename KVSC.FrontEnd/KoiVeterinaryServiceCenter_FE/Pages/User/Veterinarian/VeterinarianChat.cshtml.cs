using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class VeterinarianChatModel : PageModel
    {
        public string UserId { get; set; }
        public void OnGet(string userId)
        {
            UserId = userId;
        }
    }
}

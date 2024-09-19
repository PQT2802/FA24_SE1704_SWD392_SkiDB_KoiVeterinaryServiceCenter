using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KVSC.View.Pages.User
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginRequest Request { get; set; }

        private readonly HttpClient _httpClient;

        public LoginModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var json = JsonConvert.SerializeObject(Request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("https://localhost:7283/api/User/Login", content);

                if (response.IsSuccessStatusCode)
                {
                    // Xử lý thành công, ví dụ: chuyển hướng người dùng
                    return RedirectToPage("/Index");
                }

                ModelState.AddModelError("", "Login failed");
            }

            return Page();
        }
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.User.GetUser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Admin
{
    public class UserDetailModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public GetUserResponse UserDetail { get; set; } = new();

        public UserDetailModel(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            var result = await _userService.GetUserDetail(id);
            if (result.IsSuccess)
            {
                UserDetail = result.Data ?? new GetUserResponse();
            }
            else
            {
                UserDetail = new GetUserResponse();
            }
            if (User == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }
    }
}

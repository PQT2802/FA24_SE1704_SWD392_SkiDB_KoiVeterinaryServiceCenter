using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Admin
{
    public class UserInfoModel : PageModel
    {
        private readonly IUserService _userService;

        [BindProperty]
        public UserList UserList { get; set; } = default!;


        public bool ShowModal { get; set; } = false;

        public List<Role> Roles { get; set; } = new List<Role>();


        [BindProperty(SupportsGet = true)]
        public string FullName { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string Email { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string PhoneNumber { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string Address { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public int Role { get; set; } = 1; 

        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1; 

        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; } = 10; 

        public UserInfoModel(IUserService userService)
        {
            _userService = userService;
        }
        public async Task OnGetAsync()
        {
            await SearchUsersAsync();
            var roleResult = await _userService.GetRoleList();
            var Roles = roleResult.Data.Extensions.Data;
            if (roleResult.IsSuccess)
            {
                ViewData["Roles"] = new SelectList(Roles, "RoleId", "RoleName");
            }
            else
            {
                ViewData["Roles"] = new List<Role>();
            }
        }
        public async Task SearchUsersAsync()
        {
            var result = await _userService.GetUserList(FullName, Email, PhoneNumber, Address, Role, PageNumber, PageSize);
            if (result.IsSuccess)
            {
                UserList = result.Data ?? new UserList();
            }
            else
            {
                UserList = new UserList();
            }
        }

    }
}

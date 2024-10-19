using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.DeleteUser;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
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
        [BindProperty]
        public UpdateUserRequest UpdateUserRequest { get; set; } = default!;

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
        public async Task<IActionResult> OnPostUpdateUserAsync()
        {
            var result = await _userService.UpdateUser(UpdateUserRequest);

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
                        case "User.Empty":
                            if (error.Description.Contains("FullName", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["FullName"] = error.Description;
                            else if (error.Description.Contains("UserName", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["UserName"] = error.Description;
                            break;
                        case "User.Email.Format":
                            errorDictionary["Email"] = error.Description;
                            break;
                        case "User.Phone.Format":
                            errorDictionary["PhoneNumber"] = error.Description;
                            break;
                        default:
                            errorDictionary[string.Empty] = error.Description;
                            break;
                    }
                }
            }

            return errorDictionary;
        }
        public async Task<IActionResult> OnPostDeleteUserAsync(Guid Id)
        {
            var request = new DeleteUserRequest { Id = Id }; 
            var result = await _userService.DeleteUser(request);

            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "User deleted successfully."; 
                TempData["AlertClass"] = "alert-success";
                return RedirectToPage("/User/Admin/UserInfo");
            }

            TempData["ErrorMessage"] = "Failed to delete user: " + string.Join(", ", result.Errors.Select(e => e.Description));
            TempData["AlertClass"] = "alert-danger";
            return RedirectToPage("/User/Admin/UserInfo");
        }
    }
}

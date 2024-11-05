using KVSC.Application.Service.Implement;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using KVSC.Infrastructure.DTOs.User.GetUser;
using KVSC.Infrastructure.DTOs.Appointment;

namespace KoiVeterinaryServiceCenter_FE.Pages.Veterinarian
{
    public class VeterinarianModel : PageModel
    {
        private readonly IUserService _userService;
        public VeterinarianModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public UserList User { get; set; } = default!;

        [BindProperty]
        public GetVetInfo Veterinarians { get; set; } = default!;

        public async Task OnGetAsync()
        {
            var users = await _userService.GetUserList(string.Empty, string.Empty, string.Empty, string.Empty, 3, 1, 100);
            var vetInfo = await _userService.GetVetList();
            if (users.IsSuccess)
            {
                User = users.Data ?? new UserList();
            }
            else
            {
                User = new UserList();
            }

            if (vetInfo.IsSuccess)
            {
                Veterinarians = vetInfo.Data ?? new GetVetInfo();
            }
            else
            {
                Veterinarians = new GetVetInfo();
            }
        }
    }
}

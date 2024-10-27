using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.VeterinarianSchedule;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Manager
{
    public class ScheduleManagementModel : PageModel
    {
        private readonly IScheduleService _scheduleService ;
        
        public ScheduleDto WeeklySchedule { get; set; } = new();
        public string CurrentWeek { get; set; } = DateTime.Now.ToString("dd MMM - dd MMM yyyy");
        public List<DateTime> DaysInWeek { get; set; }
        public string[] Shifts { get; set; } = { "Morning", "Afternoon", "Evening" };
        public UserList Veterinarians { get; set; } = new();
        public ScheduleManagementModel(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        // Phương thức xử lý việc đăng ký (gán lịch)
        public async Task<IActionResult> OnPostManageAsync(
    DateTime date, string shift, string startTime, string endTime, Guid userId, bool deleteAssignment)
        {
            if (deleteAssignment && !string.IsNullOrEmpty(userId.ToString()))
            {
                var deleteResult = await _scheduleService.DeleteShiftAsync(new DeleteShiftRequest
                {
                    Date = date,
                    Shift = shift,
                    StartTime = startTime,
                    EndTime = endTime,
                    Id = userId,
                });

                if (deleteResult.IsSuccess)
                {
                    TempData["Success"] = "Shift deleted successfully!";
                    return RedirectToPage();
                }

                TempData["Error"] = "Shift assignment failed.";
                return RedirectToPage();
            }
            else if (!string.IsNullOrEmpty(userId.ToString()))
            {
                var registerResult = await _scheduleService.ManagementRegisterShiftAsync(new ManagementRegisterShiftRequest
                {
                    Date = date,
                    Shift = shift,
                    StartTime = startTime,
                    EndTime = endTime,
                    Id = userId
                });

                if (registerResult.IsSuccess)
                {
                    TempData["Success"] = "Shift assigned successfully!";
                    return RedirectToPage();
                }

                TempData["Error"] = "Shift assignment exist!";
                return RedirectToPage();
            }

            TempData["Error"] = "Shift assignment failed.";
            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetAsync(DateTime? currentDay = null)
        {
            var today = currentDay ?? DateTime.Now;
            return await OnGetWeeklyScheduleAsync(today);
        }

        public async Task<IActionResult> OnGetWeeklyScheduleAsync(DateTime currentDay)
        {
            GenerateDaysOfWeek(currentDay);
            var token = HttpContext.Session.GetString("Token");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }

            var result = await _scheduleService.GetWeeklyScheduleAsync(currentDay, token);

            if (result.IsSuccess)
            {
                WeeklySchedule = result.Data ?? new ScheduleDto();
                var vet = await _scheduleService.GetVeterList();
                Veterinarians = vet.Data ?? new UserList(); 
                CurrentWeek = GetWeekRange(currentDay);
                return Page();
            }

            CurrentWeek = GetWeekRange(currentDay);
            TempData["Error"] = "Failed to load the schedule.";
            return Page();
        }

        private void GenerateDaysOfWeek(DateTime referenceDay)
        {
            var startOfWeek = referenceDay.AddDays(-(int)referenceDay.DayOfWeek + (int)DayOfWeek.Monday);
            DaysInWeek = Enumerable.Range(0, 7)
                .Select(offset => startOfWeek.AddDays(offset))
                .ToList();
        }

        private string GetWeekRange(DateTime date)
        {
            var startOfWeek = date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Monday);
            var endOfWeek = startOfWeek.AddDays(6);
            return $"{startOfWeek:dd MMM} - {endOfWeek:dd MMM yyyy}";
        }
    }
}

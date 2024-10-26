using KVSC.Application.Service.Implement;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.VeterinarianSchedule;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;
using System.Text;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class WorkScheduleModel : PageModel
    {
        private readonly IScheduleService _scheduleService;
        public WorkScheduleModel(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        public ScheduleDto WeeklySchedule { get; set; } = new();
        public string CurrentWeek { get; set; } = DateTime.Now.ToString("dd MMM - dd MMM yyyy");

        public List<DateTime> DaysInWeek { get; set; }
        public string[] Shifts { get; set; } = { "Morning", "Afternoon", "Evening" };

        public async Task<IActionResult> OnPostRegisterAsync(DateTime date, string startTime, string endTime)
        {
            var token = HttpContext.Session.GetString("Token");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }

            var result = await _scheduleService.RegisterShiftAsync(new RegisterShiftRequest
            {
                Date = date,
                StartTime = startTime,
                EndTime = endTime
            }, token);

            if (result.IsSuccess)
            {
                TempData["Success"] = "Shift assigned successfully!";
                return new JsonResult(new { isSuccess = true });
            }

            var errors = result.Errors?.Select(e => e.Description).ToList();
            return new JsonResult(new { isSuccess = false, errors });
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

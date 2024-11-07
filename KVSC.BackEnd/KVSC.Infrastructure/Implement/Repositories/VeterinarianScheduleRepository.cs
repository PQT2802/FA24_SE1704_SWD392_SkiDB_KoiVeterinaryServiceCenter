using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class VeterinarianScheduleRepository : GenericRepository<VeterinarianSchedule>, IVeterinarianScheduleRepository
    {
        private readonly KVSCContext _context;

        public VeterinarianScheduleRepository(KVSCContext context) : base(context)
        {
            _context = context;
        }

        // Register available time for a veterinarian
        public async Task<int> RegisterAvailableTime(Guid veterinarianId, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            // Ensure no overlapping schedules
            var overlappingSchedule = await _context.VeterinarianSchedules
                .FirstOrDefaultAsync(s => s.VeterinarianId == veterinarianId && s.Date.Date == date.Date &&
                                          (s.StartTime < endTime && s.EndTime > startTime));

            var existingRegistrationsCount = await _context.VeterinarianSchedules
                .CountAsync(s => s.Date.Date == date.Date &&
                                          (s.StartTime < endTime && s.EndTime > startTime) && s.IsAvailable);

            const int maxRegistrationsPerShift = 2;

            if (existingRegistrationsCount >= maxRegistrationsPerShift)
            {
                return 0;
            }
            if (overlappingSchedule != null && overlappingSchedule.IsAvailable)
            {
                return 2;
            }
            else if (overlappingSchedule != null && !overlappingSchedule.IsAvailable)
            {
                overlappingSchedule.IsAvailable = true;//edit hung => co the assign lai neu bi xoa
            }
            else
            {
                var schedule = new VeterinarianSchedule
                {
                    VeterinarianId = veterinarianId,
                    Date = date,
                    StartTime = startTime,
                    EndTime = endTime,
                    IsAvailable = true
                };
                _context.VeterinarianSchedules.Add(schedule);
            }
            return await _context.SaveChangesAsync();
        }

        // Get the weekly schedule for a veterinarian
        public async Task<List<VeterinarianSchedule>> GetWeeklySchedule(Guid veterinarianId, DateTime startOfWeek)
        {
            var endOfWeek = startOfWeek.AddDays(7);

            return await _context.VeterinarianSchedules
                .Include(s => s.Veterinarian) // Include Veterinarian
                .ThenInclude(v => v.User) // Include the related User entity for veterinarian's name
                .Where(s => s.VeterinarianId == veterinarianId && s.Date >= startOfWeek && s.Date <= endOfWeek)
                .OrderBy(s => s.Date)
                .ThenBy(s => s.StartTime)
                .ToListAsync();
        }

        //// Get the weekly schedule for all veterinarians
        //public async Task<List<VeterinarianSchedule>> GetAllVeterinariansWeeklySchedule(DateTime startOfWeek) // chi lay duoc 1 tuan nen bo 
        //{
        //    var endOfWeek = startOfWeek.AddDays(6);

        //    return await _context.VeterinarianSchedules
        //        .Include(s => s.Veterinarian) // Include the Veterinarian entity
        //        .ThenInclude(v => v.User) // Include the related User entity to access the name
        //        .Where(s => s.Date >= startOfWeek && s.Date <= endOfWeek)
        //        .OrderBy(s => s.Date)
        //        .ThenBy(s => s.StartTime)
        //        .ToListAsync();
        //}
        public async Task<List<VeterinarianSchedule>> GetAllVeterinariansScheduleAsync(DateTime startOfPeriod, DateTime endOfPeriod)
        {
            return await _context.VeterinarianSchedules
                .Include(s => s.Veterinarian) 
                .ThenInclude(v => v.User)
                .Where(s => s.Date >= startOfPeriod && s.Date <= endOfPeriod)
                .OrderBy(s => s.Date)
                .ThenBy(s => s.StartTime)
                .ToListAsync();
        }


        // Update the schedule's availability after an appointment is assigned
        public async Task UpdateScheduleAvailability(Guid veterinarianId, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            var schedule = await _context.VeterinarianSchedules
                .FirstOrDefaultAsync(s => s.VeterinarianId == veterinarianId && s.Date.Date == date.Date &&
                                          (s.StartTime < endTime && s.EndTime > startTime));

            if (schedule == null) return;

            schedule.IsAvailable = false;
            _context.VeterinarianSchedules.Update(schedule);
            await _context.SaveChangesAsync();
        }
        public async Task<Veterinarian> GetVeterinarianByUserIdAsync(Guid userId)
        {
            return await _context.Veterinarians
                .Include(v => v.User) // Include User to fetch User details if needed
                .FirstOrDefaultAsync(v => v.UserId == userId);
        }
        public async Task<List<VeterinarianSchedule>> GetAvailableVeterinariansForDateAsync(DateTime appointmentDate)
        {
            return await _context.VeterinarianSchedules
                .Include(v => v.Veterinarian).ThenInclude(u => u.User)
                .Where(s => s.Date == appointmentDate.Date && s.IsAvailable)
                .ToListAsync();
        }
        public async Task<List<VeterinarianSchedule>> GetAvailableVeterinariansForDateTimeAsync(DateTime selectedDate, TimeSpan startTime, TimeSpan endTime)
        {
            return await _context.VeterinarianSchedules
                .Include(v => v.Veterinarian)
                .ThenInclude(u => u.User)
                .Where(s => s.Date.Date == selectedDate.Date && s.IsAvailable
                            && s.StartTime <= endTime && s.EndTime >= startTime) // Allows overlapping time ranges
                .OrderBy(s => s.Date)
                .ThenBy(s => s.StartTime)
                .ToListAsync();
        }

        public async Task<List<VeterinarianSchedule>> GetAvailableVeterinariansForBookingAppointmentAsync(DateTime appointmentDate, TimeSpan duration)
        {
            // Tính toán thời gian kết thúc của cuộc hẹn được yêu cầu
            var requestedEndTime = appointmentDate.TimeOfDay.Add(duration);

            // Lấy tất cả các bác sĩ có lịch làm việc trong ngày được chọn
            var vetSchedules = await _context.VeterinarianSchedules
                .Include(v => v.Veterinarian)
                .ThenInclude(u => u.User)
                .Where(v => v.Date.Date == appointmentDate.Date && v.IsAvailable)
                .ToListAsync();

            var availableVets = new List<VeterinarianSchedule>();

            foreach (var schedule in vetSchedules)
            {
                // Lấy các cuộc hẹn của bác sĩ trong ca làm việc
                var appointments = await _context.Appointments
                    .Where(a => a.AppointmentVeterinarians.Any(av => av.VeterinarianId == schedule.VeterinarianId) &&
                                a.AppointmentDate.Date == appointmentDate.Date &&
                                a.AppointmentDate.TimeOfDay >= schedule.StartTime &&
                                a.EndDate.Value.TimeOfDay <= schedule.EndTime)
                    .OrderBy(a => a.AppointmentDate)
                    .ToListAsync();

                // Theo dõi các khoảng thời gian trống trong ca làm việc của bác sĩ
                var freeSlots = new List<(TimeSpan Start, TimeSpan End)>();

                // Thêm khoảng trống trước cuộc hẹn đầu tiên nếu có
                if (appointments.Any() && appointments.First().AppointmentDate.TimeOfDay > schedule.StartTime)
                {
                    freeSlots.Add((schedule.StartTime, appointments.First().AppointmentDate.TimeOfDay));
                }

                // Thêm các khoảng trống giữa các cuộc hẹn
                for (int i = 0; i < appointments.Count - 1; i++)
                {
                    var currentEnd = appointments[i].EndDate?.TimeOfDay ?? TimeSpan.Zero;
                    var nextStart = appointments[i + 1].AppointmentDate.TimeOfDay;

                    if (currentEnd < nextStart)
                    {
                        freeSlots.Add((currentEnd, nextStart));
                    }
                }

                // Thêm khoảng trống sau cuộc hẹn cuối cùng
                if (appointments.Any() && appointments.Last().EndDate?.TimeOfDay < schedule.EndTime)
                {
                    freeSlots.Add((appointments.Last().EndDate?.TimeOfDay ?? TimeSpan.Zero, schedule.EndTime));
                }
                else if (!appointments.Any()) // Nếu không có cuộc hẹn nào, toàn bộ ca làm việc là thời gian trống
                {
                    freeSlots.Add((schedule.StartTime, schedule.EndTime));
                }

                // Kiểm tra nếu khoảng thời gian yêu cầu có thể được xếp vào bất kỳ khoảng trống nào
                foreach (var slot in freeSlots)
                {
                    if (appointmentDate.TimeOfDay >= slot.Start && requestedEndTime <= slot.End)
                    {
                        availableVets.Add(schedule);
                        break;
                    }
                }
            }

            return availableVets;
        }


    }
}

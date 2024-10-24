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
        public async Task RegisterAvailableTime(Guid veterinarianId, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            // Ensure no overlapping schedules
            var overlappingSchedule = await _context.VeterinarianSchedules
                .FirstOrDefaultAsync(s => s.VeterinarianId == veterinarianId && s.Date == date &&
                                          (s.StartTime <= endTime && s.EndTime >= startTime));

            if (overlappingSchedule != null)
            {
                throw new InvalidOperationException("Schedule overlaps with an existing one.");
            }

            var schedule = new VeterinarianSchedule
            {
                VeterinarianId = veterinarianId,
                Date = date,
                StartTime = startTime,
                EndTime = endTime,
                IsAvailable = true
            };

            _context.VeterinarianSchedules.Add(schedule);
            await _context.SaveChangesAsync();
        }

        // Get the weekly schedule for a veterinarian
        public async Task<List<VeterinarianSchedule>> GetWeeklySchedule(Guid veterinarianId, DateTime startOfWeek)
        {
            var endOfWeek = startOfWeek.AddDays(7);

            return await _context.VeterinarianSchedules
                .Where(s => s.VeterinarianId == veterinarianId && s.Date >= startOfWeek && s.Date <= endOfWeek)
                .OrderBy(s => s.Date)
                .ThenBy(s => s.StartTime)
                .ToListAsync();
        }

        // Update the schedule's availability after an appointment is assigned
        public async Task UpdateScheduleAvailability(Guid veterinarianId, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            var schedule = await _context.VeterinarianSchedules
                .FirstOrDefaultAsync(s => s.VeterinarianId == veterinarianId && s.Date == date && s.StartTime == startTime && s.EndTime == endTime);

            if (schedule == null) return;

            schedule.IsAvailable = false;
            _context.VeterinarianSchedules.Update(schedule);
            await _context.SaveChangesAsync();
        }
    }
}

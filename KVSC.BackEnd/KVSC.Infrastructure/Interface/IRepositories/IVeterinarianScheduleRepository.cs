using KVSC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IVeterinarianScheduleRepository : IGenericRepository<VeterinarianSchedule>
    {
        Task<int> RegisterAvailableTime(Guid veterinarianId, DateTime date, TimeSpan startTime, TimeSpan endTime);
        Task<List<VeterinarianSchedule>> GetWeeklySchedule(Guid veterinarianId, DateTime startOfWeek);
        Task UpdateScheduleAvailability(Guid veterinarianId, DateTime date, TimeSpan startTime, TimeSpan endTime);

        Task<List<VeterinarianSchedule>> GetAllVeterinariansScheduleAsync(DateTime startOfPeriod, DateTime endOfPeriod);

        Task<Veterinarian> GetVeterinarianByUserIdAsync(Guid userId);

        Task<List<VeterinarianSchedule>> GetAvailableVeterinariansForDateAsync(DateTime appointmentDate);
        Task<List<VeterinarianSchedule>> GetAvailableVeterinariansForDateTimeAsync(DateTime selectedDate, TimeSpan startTime, TimeSpan endTime);
    }
}


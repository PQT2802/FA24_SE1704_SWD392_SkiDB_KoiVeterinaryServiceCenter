using KVSC.Domain.Entities;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IAppointmentRepository : IGenericRepository<Appointment>
    {
        public Task<Appointment> CreateAppointmentAsync(Appointment appointment);

        // READ (các phương thức khác nếu cần)
        public Task<IEnumerable<Appointment>> GetAllAppointmentsAsync();

        public Task<Veterinarian> GetAvailableVeterinarianAsync(DateTime appointmentDate);
        public Task UpdateScheduleAvailabilityAsync(Guid veterinarianId, DateTime appointmentDate);

        Task<bool> IsVeterinarianAvailableAsync(Guid veterinarianId, DateTime appointmentDate);
    }
}

using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.DTOs.Appointment.GetAppointment;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(KVSCContext context) : base(context) { }

        // CREATE
        public async Task<Appointment> CreateAppointmentAsync(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return appointment;
        }

        // READ (các phương thức khác nếu cần)
        public async Task<IEnumerable<Appointment>> GetAllAppointmentsAsync()
        {
            return await _context.Appointments.Where(a => !a.IsDeleted).ToListAsync();
        }


        public async Task<IEnumerable<GetAllAppointment>> GetAppointmentListAsync()
        {
            return await _context.Appointments
                .Where(a => !a.IsDeleted)
                .Select(a => new GetAllAppointment
                {
                    AppointmentListId = a.Id,
                    CustomerId = a.CustomerId,
                    PetServiceId = a.PetServiceId ?? Guid.Empty, // Handle null PetServiceId with default value
                    VeterinarianId = a.AppointmentVeterinarians
                                        .Select(av => av.VeterinarianId)
                                        .FirstOrDefault(), // Return the first VeterinarianId or default
                    CustomerName = a.Customer != null ? a.Customer.FullName : "Unknown", // Handle null Customer
                    VeterinarianName = a.AppointmentVeterinarians
                                        .Select(av => av.Veterinarian != null ? av.Veterinarian.User.FullName : "Unknown")
                                        .FirstOrDefault(), // Handle null Veterinarian or User
                    ServiceName = a.PetService != null ? a.PetService.Name : "N/A", // Handle null PetService
                    Status = a.Status,
                    AppointmentDate = a.AppointmentDate
                })
                .ToListAsync();
        }
        public async Task<IEnumerable<GetAllAppointment>> GetAppointmentListByUserIdAsync(Guid userId)
        {
            return await _context.Appointments
                .Where(a => !a.IsDeleted && a.AppointmentVeterinarians
                    .Any(av => av.Veterinarian.UserId == userId)) // Filter by veterinarian's UserId
                .Select(a => new GetAllAppointment
                {
                    AppointmentListId = a.Id,
                    CustomerId = a.CustomerId,
                    PetServiceId = a.PetServiceId ?? Guid.Empty, // Handle nullable PetServiceId with Guid.Empty
                    VeterinarianId = a.AppointmentVeterinarians
                                        .Where(av => av.Veterinarian.UserId == userId) // Filter by the provided UserId
                                        .Select(av => av.VeterinarianId)
                                        .FirstOrDefault(), // Return the first matching VeterinarianId
                    CustomerName = a.Customer != null ? a.Customer.FullName : "Unknown", // Handle null Customer safely
                    VeterinarianName = a.AppointmentVeterinarians
                                        .Where(av => av.Veterinarian.UserId == userId) // Filter for the correct veterinarian
                                        .Select(av => av.Veterinarian != null ? av.Veterinarian.User.FullName : "Unknown")
                                        .FirstOrDefault(), // Handle null Veterinarian or User
                    ServiceName = a.PetService != null ? a.PetService.Name : "N/A", // Handle null PetService safely
                    Status = a.Status,
                    AppointmentDate = a.AppointmentDate
                })
                .ToListAsync();
        }



        public async Task<Veterinarian> GetAvailableVeterinarianAsync(DateTime appointmentDate)
        {
            var appointmentDay = appointmentDate.Date;   
            var appointmentTime = appointmentDate.TimeOfDay; 

            var availableVeterinarian = await _context.Veterinarians
            .Include(v => v.VeterinarianSchedules)
            .Where(v => v.VeterinarianSchedules.Any(s =>
                s.Date == appointmentDay &&       
                s.StartTime <= appointmentTime && 
                s.EndTime >= appointmentTime &&
                s.IsAvailable
            ))
            .FirstOrDefaultAsync();


            return availableVeterinarian;
        }
        public async Task UpdateScheduleAvailabilityAsync(Guid veterinarianId, DateTime appointmentDate)
        {
            var appointmentDay = appointmentDate.Date;
            var appointmentTime = appointmentDate.TimeOfDay;

            var schedule = await _context.VeterinarianSchedules
                .FirstOrDefaultAsync(s => s.VeterinarianId == veterinarianId
                    && s.Date == appointmentDate.Date
                    && s.StartTime <= appointmentTime
                    && s.EndTime >= appointmentTime);

            if (schedule != null)
            {
                schedule.IsAvailable = false; 
                _context.VeterinarianSchedules.Update(schedule);
                await _context.SaveChangesAsync(); 
            }
        }
    } 
}

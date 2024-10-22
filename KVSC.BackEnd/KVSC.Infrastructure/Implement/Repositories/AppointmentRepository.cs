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
        public async Task<bool> AppointmentExistsAsync(Guid appointmentId)
        {
            return await _context.Appointments.AnyAsync(a => a.Id == appointmentId && !a.IsDeleted);
        }
        public async Task<Guid> UpdateAppointmentStatusAsync(Guid appointmentId, string status)
        {
            try
            {
                // Find the appointment based on the provided ID
                var appointment = await _context.Appointments.FirstOrDefaultAsync(a => a.Id == appointmentId);

                // If no appointment is found, return 0
                if (appointment == null)
                {
                    return Guid.Empty;
                }

                // Update the status of the found appointment
                appointment.Status = status;

                // Save the changes to the database
                 await _context.SaveChangesAsync();
                return appointment.Id;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the operation
                throw new InvalidOperationException("Error updating appointment status.", ex);
            }
        }
    } 
}

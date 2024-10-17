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
            AppointmentListId = a.Id, // Assuming Id is the primary key in Appointment
            CustomerId = a.CustomerId,
            PetServiceId = a.PetServiceId ?? Guid.Empty, // Handle nullable with a default value if needed
            VeterinarianId = a.AppointmentVeterinarians.Select(av => av.VeterinarianId).FirstOrDefault(), // Assuming you want the first veterinarian ID
            CustomerName = a.Customer.FullName, // Ensure Customer entity has Name property
            VeterinarianName = a.AppointmentVeterinarians.Select(av => av.Veterinarian.User.FullName).FirstOrDefault(), // Assuming AppointmentVeterinarian has a navigation property for Veterinarian
            ServiceName = a.PetService != null ? a.PetService.Name : "N/A", // Assuming PetService entity has Name property, handle nulls appropriately
            Status = a.Status,
            AppointmentDate = a.AppointmentDate
        })
        .ToListAsync();
        }
        public async Task<IEnumerable<GetAllAppointment>> GetAppointmentListByVetIdAsync(Guid veterinarianId)
        {
            return await _context.Appointments
        .Where(a => !a.IsDeleted && a.AppointmentVeterinarians.Any(av => av.VeterinarianId == veterinarianId)) // Filter by veterinarian ID
        .Select(a => new GetAllAppointment
        {
            AppointmentListId = a.Id, // Assuming Id is the primary key in Appointment
            CustomerId = a.CustomerId,
            PetServiceId = a.PetServiceId ?? Guid.Empty, // Handle nullable with a default value if needed
            VeterinarianId = a.AppointmentVeterinarians.Select(av => av.VeterinarianId).FirstOrDefault(), // Assuming you want the first veterinarian ID
            CustomerName = a.Customer.FullName, // Ensure Customer entity has Name property
            VeterinarianName = a.AppointmentVeterinarians.Select(av => av.Veterinarian.User.FullName).FirstOrDefault(), // Assuming AppointmentVeterinarian has a navigation property for Veterinarian
            ServiceName = a.PetService != null ? a.PetService.Name : "N/A", // Assuming PetService entity has Name property, handle nulls appropriately
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
    } 
}

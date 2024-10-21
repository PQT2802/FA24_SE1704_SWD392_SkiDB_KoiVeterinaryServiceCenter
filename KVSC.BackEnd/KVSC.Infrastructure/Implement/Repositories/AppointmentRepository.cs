using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.DTOs.Appointment.GetAppointment;
using KVSC.Infrastructure.DTOs.Appointment.GetAppointmentDetail;
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

        public async Task<GetAppointmentDetail> GetAppointmentDetailAsync(Guid appointmentId)
        {
            // Fetch the appointment with related entities
            var appointment = await _context.Appointments
                .Include(a => a.Customer)
                .Include(a => a.PetService)
                .Include(a => a.AppointmentVeterinarians)
                    .ThenInclude(av => av.Veterinarian)
                        .ThenInclude(v => v.User)
                .Include(a => a.Pet)
                .Include(a => a.ComboService)
                .Include(a => a.ServiceReport)
                    .ThenInclude(r => r.Prescription)
                        .ThenInclude(p => p.PrescriptionDetails)
                .FirstOrDefaultAsync(a => a.Id == appointmentId && !a.IsDeleted);

            if (appointment == null)
            {
                return null;
            }

            // Map the appointment details to the DTOs
            var appointmentDetail = new GetAppointmentDetail
            {
                AppointmentDetailService = new AppointmentDetailService
                {
                    ServiceName = appointment.PetService?.Name ?? "N/A",
                    ServiceCategory = appointment.PetService?.PetServiceCategory.Name ?? "N/A",
                    PetDescription = appointment.Pet?.Note ?? "No description",
                    CreateDate = appointment.CreatedDate,
                    AppointmentDate = appointment.AppointmentDate,
                    Cost = appointment.PetService?.BasePrice ?? 0,
                    Duration = appointment.PetService?.Duration ?? "N/A"
                },
                AppointmentDetailCustomer = new AppointmentDetailCustomer
                {
                    FullName = appointment.Customer?.FullName ?? "N/A",
                    Email = appointment.Customer?.Email ?? "N/A",
                    PhoneNumber = appointment.Customer?.PhoneNumber ?? "N/A",
                    Address = appointment.Customer?.Address ?? "N/A"
                },
                AppointmentDetailVeterinarian = appointment.AppointmentVeterinarians
                    .Select(av => new AppointmentDetailVeterinarian
                    {
                        FullName = av.Veterinarian.User?.FullName ?? "N/A",
                        Email = av.Veterinarian.User?.Email ?? "N/A",
                        PhoneNumber = av.Veterinarian.User?.PhoneNumber ?? "N/A",
                        Address = av.Veterinarian.User?.Address ?? "N/A",
                        Specialty = av.Veterinarian.Specialty ?? "N/A",
                        LicenseNumber = av.Veterinarian.LicenseNumber ?? "N/A"
                    })
                    .FirstOrDefault(), // If multiple veterinarians, return the first
                AppointmentDetailKoi = new AppointmentDetailKoi
                {
                    Name = appointment.Pet?.Name ?? "N/A",
                    Age = appointment.Pet?.Age,
                    Quantity = appointment.Pet?.Quantity ?? 0,
                    Color = appointment.Pet?.Color ?? "N/A",
                    Length = appointment.Pet?.Length,
                    Weight = appointment.Pet?.Weight
                },
                AppointmentDetailReport = appointment.ServiceReport != null ? new AppointmentDetailReport
                {
                    ReportContent = appointment.ServiceReport.ReportContent,
                    ReportDate = appointment.ServiceReport.ReportDate,
                    Recommendations = appointment.ServiceReport.Recommendations,
                    PrescriptionDetail = appointment.ServiceReport.Prescription?.PrescriptionDetails.Select(pd => new PrescriptionDetails
                    {
                        // Update to access the Medicine's Name property
                        MedicineName = pd.Medicine?.Name ?? "N/A", // Use pd.Medicine.Name
                        Quantity = pd.Quantity,
                        Price = pd.Price
                    }).ToList()
                } : null
            };

            return appointmentDetail;
        }
    } 
}

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
                            .ThenInclude(pd => pd.Medicine)
                .FirstOrDefaultAsync(a => a.Id == appointmentId && !a.IsDeleted);

            if (appointment == null)
            {
                return null;
            }

            // Map the appointment details to the DTOs
            // Initialize the GetAppointmentDetail object
            var appointmentDetail = new GetAppointmentDetail();

            // Debugging AppointmentDetailService
            if (appointment.PetService == null)
            {
                Console.WriteLine("appointment.PetService is null");
            }
            else
            {
                var serviceCategory = appointment.PetService.PetServiceCategory?.Name ?? "N/A";
                if (appointment.PetService.PetServiceCategory == null)
                    Console.WriteLine("appointment.PetService.PetServiceCategory is null");

                appointmentDetail.AppointmentDetailService = new AppointmentDetailService
                {
                    ServiceName = appointment.PetService.Name ?? "N/A",
                    ServiceCategory = serviceCategory,
                    PetDescription = appointment.Pet?.Note ?? "No description",
                    CreateDate = appointment.CreatedDate,
                    AppointmentDate = appointment.AppointmentDate,
                    Cost = appointment.PetService.BasePrice,
                    Duration = appointment.PetService.Duration ?? "N/A"
                };
            }

            // Debugging AppointmentDetailCustomer
            if (appointment.Customer == null)
            {
                Console.WriteLine("appointment.Customer is null");
            }
            else
            {
                appointmentDetail.AppointmentDetailCustomer = new AppointmentDetailCustomer
                {
                    FullName = appointment.Customer.FullName ?? "N/A",
                    Email = appointment.Customer.Email ?? "N/A",
                    PhoneNumber = appointment.Customer.PhoneNumber ?? "N/A",
                    Address = appointment.Customer.Address ?? "N/A"
                };
            }

            // Debugging AppointmentDetailVeterinarian
            if (appointment.AppointmentVeterinarians == null || !appointment.AppointmentVeterinarians.Any())
            {
                Console.WriteLine("appointment.AppointmentVeterinarians is null or empty");
            }
            else
            {
                var firstVeterinarian = appointment.AppointmentVeterinarians.FirstOrDefault();
                if (firstVeterinarian != null && firstVeterinarian.Veterinarian?.User == null)
                {
                    Console.WriteLine("firstVeterinarian.Veterinarian.User is null");
                }
                else
                {
                    appointmentDetail.AppointmentDetailVeterinarian = new AppointmentDetailVeterinarian
                    {
                        FullName = firstVeterinarian?.Veterinarian?.User?.FullName ?? "N/A",
                        Email = firstVeterinarian?.Veterinarian?.User?.Email ?? "N/A",
                        PhoneNumber = firstVeterinarian?.Veterinarian?.User?.PhoneNumber ?? "N/A",
                        Address = firstVeterinarian?.Veterinarian?.User?.Address ?? "N/A",
                        Specialty = firstVeterinarian?.Veterinarian?.Specialty ?? "N/A",
                        LicenseNumber = firstVeterinarian?.Veterinarian?.LicenseNumber ?? "N/A"
                    };
                }
            }

            // Debugging AppointmentDetailKoi
            if (appointment.Pet == null)
            {
                Console.WriteLine("appointment.Pet is null");
            }
            else
            {
                appointmentDetail.AppointmentDetailKoi = new AppointmentDetailKoi
                {
                    Name = appointment.Pet.Name ?? "N/A",
                    Age = appointment.Pet.Age,
                    Quantity = appointment.Pet.Quantity,
                    Color = appointment.Pet.Color ?? "N/A",
                    Length = appointment.Pet.Length,
                    Weight = appointment.Pet.Weight
                };
            }

            // Debugging AppointmentDetailReport
            if (appointment.ServiceReport == null)
            {
                Console.WriteLine("appointment.ServiceReport is null");
            }
            else
            {
                var prescriptionDetails = appointment.ServiceReport.Prescription?.PrescriptionDetails?.Select(pd => new PrescriptionDetails
                {
                    MedicineName = pd.Medicine?.Name ?? "N/A",
                    Quantity = pd.Quantity,
                    Price = pd.Price
                }).ToList();

                if (appointment.ServiceReport.Prescription == null)
                    Console.WriteLine("appointment.ServiceReport.Prescription is null");

                appointmentDetail.AppointmentDetailReport = new AppointmentDetailReport
                {
                    ReportContent = appointment.ServiceReport.ReportContent,
                    ReportDate = appointment.ServiceReport.ReportDate,
                    Recommendations = appointment.ServiceReport.Recommendations,
                    PrescriptionDetail = prescriptionDetails
                };
            }
            return appointmentDetail;
        }
        public async Task<Appointment> GetAppointmentByIdAsync(Guid appointmentId)
        {
            return await _context.Appointments
                .Include(a => a.Customer)
                .Include(a => a.PetService)
                .Include(a => a.AppointmentVeterinarians)
                    .ThenInclude(av => av.Veterinarian)
                .Include(a => a.Pet)
                .Include(a => a.ComboService)
                .Include(a => a.ServiceReport)
                .FirstOrDefaultAsync(a => a.Id == appointmentId && !a.IsDeleted);
        }
        public async Task AssignVeterinarianToAppointment(Guid appointmentId, Guid veterinarianId)
        {
            var appointment = await _context.Appointments
                .Include(a => a.AppointmentVeterinarians) // Include current veterinarians
                .FirstOrDefaultAsync(a => a.Id == appointmentId && !a.IsDeleted);

            if (appointment == null)
            {
                throw new InvalidOperationException("Appointment not found.");
            }

            // Ensure the veterinarian is not already assigned
            if (!appointment.AppointmentVeterinarians.Any(av => av.VeterinarianId == veterinarianId))
            {
                var appointmentVeterinarian = new AppointmentVeterinarian
                {
                    AppointmentId = appointmentId,
                    VeterinarianId = veterinarianId
                };

                appointment.AppointmentVeterinarians.Add(appointmentVeterinarian);
                await _context.SaveChangesAsync();
            }
        }


    }
}

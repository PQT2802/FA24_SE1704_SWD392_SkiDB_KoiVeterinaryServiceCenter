using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.DTOs.Dashboard.Admin;
using KVSC.Infrastructure.DTOs.Dashboard.Manager;
using KVSC.Infrastructure.DTOs.Dashboard.Vet;
using KVSC.Infrastructure.Interface.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly KVSCContext _context;

        public DashboardRepository(KVSCContext context)
        {
            _context = context;
        }

        //MANAGER
        public async Task<int> GetTotalCustomersAsync()
        {
            return await _context.Users.CountAsync(u => u.role == 5);
        }

        public async Task<int> GetTotalVeterinariansAsync()
        {
            return await _context.Users.CountAsync(u => u.role == 3);
        }

        public async Task<int> GetTotalStaffAsync()
        {
            return await _context.Users.CountAsync(u => u.role == 4);
        }

        public async Task<decimal> GetTotalPaymentsAsync()
        {
            return await _context.Payments
                                 .Where(p => p.totalAmountStatus)
                                 .SumAsync(p => p.TotalAmount);
        }

        public async Task<Dictionary<string, int>> GetAllAppointmentAsync()
        {
            var appointmentCounts = new Dictionary<string, int>();

            appointmentCounts["Pending"] = await _context.Appointments.CountAsync(a => a.Status == "Pending");
            appointmentCounts["InProgress"] = await _context.Appointments.CountAsync(a => a.Status == "InProgress");
            appointmentCounts["Completed"] = await _context.Appointments.CountAsync(a => a.Status == "Completed");
            appointmentCounts["Reported"] = await _context.Appointments.CountAsync(a => a.Status == "Reported");
            appointmentCounts["Cancelled"] = await _context.Appointments.CountAsync(a => a.Status == "Cancelled");

            return appointmentCounts;
        }

        public async Task<List<PetServiceTopBooking>> GetTopServicesByBookingsAsync()
        {
            return await _context.Appointments
                .Where(a => a.PetServiceId.HasValue)
                .GroupBy(a => a.PetServiceId)
                .Select(g => new PetServiceTopBooking
                {
                    PetServiceId = g.Key,
                    ServiceName = g.FirstOrDefault().PetService.Name,
                    BookingsCount = g.Count()
                })
                .OrderByDescending(s => s.BookingsCount)
                .ToListAsync();
        }

        public async Task<List<PetServiceTopRating>> GetTopServicesByRatingAsync()
        {
            return await _context.Ratings
                .GroupBy(r => r.ServiceId)
                .Select(g => new PetServiceTopRating
                {
                    PetServiceId = g.Key,
                    ServiceName = g.FirstOrDefault().Service.Name,
                    AverageRating = g.Average(r => r.Score)
                })
                .OrderByDescending(s => s.AverageRating)
                .ToListAsync();
        }

        public async Task<List<PetServiceTopCancellation>> GetTopServicesByCancellationsAsync()
        {
            return await _context.Appointments
                .Where(a => a.Status == "Cancelled" && a.PetServiceId.HasValue)
                .GroupBy(a => a.PetServiceId)
                .Select(g => new PetServiceTopCancellation
                {
                    PetServiceId = g.Key,
                    ServiceName = g.FirstOrDefault().PetService.Name,
                    CancellationsCount = g.Count()
                })
                .OrderByDescending(s => s.CancellationsCount)
                .ToListAsync();
        }

        //CUSTOMER
        public async Task<int> GetCustomerPetAsync(Guid customerId)
        {
            return await _context.Pets
                .Where(p => p.OwnerId == customerId && !p.IsDeleted) 
                .CountAsync();
        }

        public async Task<int> GetCustomerAppointmentAsync(Guid customerId)
        {
            return await _context.Appointments.CountAsync(a => a.CustomerId == customerId);
        }

        public async Task<decimal> GetCustomerPaymentAsync(Guid customerId)
        {
            return await _context.Payments
            .Where(p => p.Appointment.CustomerId == customerId)
            .SumAsync(p => p.TotalAmount);
        }

        public async Task<Dictionary<DateTime, int>> GetMonthlyCustomerAppointmentsAsync(Guid customerId, int months)
        {
            var startDate = DateTime.Now.AddMonths(-months);

            var appointments = await _context.Appointments
                .Where(a => a.CustomerId == customerId && a.AppointmentDate >= startDate)
                .ToListAsync();

            var monthlyAppointments = appointments
                .GroupBy(a => new DateTime(a.AppointmentDate.Year, a.AppointmentDate.Month, 1))
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Count());

            return monthlyAppointments;
        }

        public async Task<Dictionary<DateTime, decimal>> GetMonthlyCustomerPaymentsAsync(Guid customerId, int months)
        {
            var startDate = DateTime.Now.AddMonths(-months);

            var payments = await _context.Payments
                .Where(p => p.Appointment.CustomerId == customerId && p.CreatedDate >= startDate)
                .ToListAsync();

            var monthlyPayments = payments
                .GroupBy(p => new DateTime(p.CreatedDate.Year, p.CreatedDate.Month, 1))
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Sum(p => p.TotalAmount));

            return monthlyPayments;
        }

        //VET
        public async Task<Guid?> GetVeterinarianIdByUserIdAsync(Guid userId)
        {
            return await _context.Users
                .Where(u => u.Id == userId)
                .Select(u => u.Veterinarian.Id)
                .FirstOrDefaultAsync();
        }

        public async Task<int> GetVeterinarianCustomersAsync(Guid userId)
        {
            var veterinarianId = await GetVeterinarianIdByUserIdAsync(userId);
            if (veterinarianId == null) return 0;

            return await _context.Appointments
                .Where(a => a.AppointmentVeterinarians.Any(v => v.VeterinarianId == veterinarianId))
                .Select(a => a.CustomerId)
                .Distinct()
                .CountAsync();
        }

        public async Task<int> GetVeterinarianAppointmentAsync(Guid userId)
        {
            var veterinarianId = await GetVeterinarianIdByUserIdAsync(userId);
            if (veterinarianId == null) return 0;

            return await _context.Appointments
                .Where(a => a.AppointmentVeterinarians.Any(v => v.VeterinarianId == veterinarianId))
                .CountAsync();
        }

        public async Task<List<UpcomingAppointment>> GetNextUpcomingAppointmentAsync(Guid userId)
        {
            var veterinarianId = await GetVeterinarianIdByUserIdAsync(userId);
            if (veterinarianId == null) return new List<UpcomingAppointment>();

            return await _context.Appointments
                .Where(a => a.Status == "Waiting" && a.AppointmentVeterinarians.Any(v => v.VeterinarianId == veterinarianId))
                .OrderBy(a => a.AppointmentDate)
                .Select(a => new UpcomingAppointment
                {
                    AppointmentId = a.Id,
                    AppointmentDate = a.AppointmentDate,
                    CustomerName = a.Customer.FullName,
                    ServiceName = a.PetService.Name
                })
                .ToListAsync();
        }

        public async Task<List<CompletedAppointment>> GetNewestCompletedAppointmentAsync(Guid userId)
        {
            var veterinarianId = await GetVeterinarianIdByUserIdAsync(userId);
            if (veterinarianId == null) return new List<CompletedAppointment>();

            return await _context.Appointments
                .Where(a => a.Status == "Completed" && a.AppointmentVeterinarians.Any(v => v.VeterinarianId == veterinarianId))
                .OrderByDescending(a => a.CompletedDate)
                .Select(a => new CompletedAppointment
                {
                    AppointmentId = a.Id,
                    CompletedDate = a.CompletedDate,
                    CustomerName = a.Customer.FullName,
                    ServiceName = a.PetService.Name
                })
                .ToListAsync();
        }

        public async Task<List<PendingAppointment>> GetPendingAppointmentAsync()
        {
            return await _context.Appointments
                .Where(a => a.Status == "Pending")
                .Select(a => new PendingAppointment
                {
                    AppointmentId = a.Id,
                    AppointmentDate = a.AppointmentDate,
                    CustomerName = a.Customer.FullName,
                    ServiceName = a.PetService.Name
                })
                .ToListAsync();
        }


        //ADMIN

        public async Task<int> GetTotalManagersAsync()
        {
            return await _context.Users.CountAsync(u => u.role == 2);
        }

        public async Task<int> GetTotalUsersAsync()
        {
            return await _context.Users.CountAsync(u => u.role != 1);
        }

    }
}

using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.DTOs.Dashboard.Manager;
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

        //ADMIN
        public async Task<List<Veterinarian>> GetTopVeterinariansByAppointmentsAsync(int topCount)
        {
            return await _context.Veterinarians
                .Include(v => v.User)
                .Include(v => v.AppointmentVeterinarians)
                .OrderByDescending(v => v.AppointmentVeterinarians.Count)
                .Take(topCount)
                .ToListAsync();
        }

        public async Task<List<PetService>> GetBestServicesByRatingAsync(int topCount)
        {
            return await _context.PetServices
                .Include(s => s.Ratings)
                .OrderByDescending(s => s.Ratings.Average(r => r.Score))
                .Take(topCount)
                .ToListAsync();
        }

        public async Task<List<Product>> GetTopSellingProductsAsync(int topCount)
        {
            return await _context.Products
                .Include(p => p.OrderItems)
                .OrderByDescending(p => p.OrderItems.Count)
                .Take(topCount)
                .ToListAsync();
        }

        //VET
        public async Task<List<Appointment>> GetNewestCompletedAppointmentAsync()
        {
            return await _context.Appointments
                .Include(a => a.Customer)
                .Include(a => a.PetService)
                .Include(a => a.ComboService)
                .Where(a => a.CompletedDate.HasValue)
                .OrderByDescending(a => a.CompletedDate)
                .ToListAsync();
        }

        public async Task<List<Appointment>> GetNextUpcomingAppointmentAsync()
        {
            return await _context.Appointments
                .Include(a => a.Customer)
                .Include(a => a.PetService)
                .Include(a => a.ComboService)
                .Where(a => a.Status == "Accepted" && a.AppointmentDate > a.AcceptedDate)
                .OrderBy(a => a.AppointmentDate)
                .ToListAsync();
        }

        public Task<int> GetVetAppointmentAsync()
        {
            throw new NotImplementedException();
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
            return await _context.Pets.CountAsync(p => p.OwnerId == customerId);
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
                .Where(p => p.Appointment.CustomerId == customerId && p.Appointment.AppointmentDate >= startDate)
                .ToListAsync();

            var monthlyPayments = payments
                .GroupBy(p => new DateTime(p.Appointment.AppointmentDate.Year, p.Appointment.AppointmentDate.Month, 1))
                .OrderBy(g => g.Key) 
                .ToDictionary(g => g.Key, g => g.Sum(p => p.TotalAmount));

            return monthlyPayments;
        }
    }
}

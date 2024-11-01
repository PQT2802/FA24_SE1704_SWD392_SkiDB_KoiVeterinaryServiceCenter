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
        public Task<int> GetTotalUserAsync()
        {
            throw new NotImplementedException();
        }

        //VET
        public async Task<List<Appointment>> GetNewestCompletedAppointmentAsync(int topCount)
        {
            return await _context.Appointments
                .Include(a => a.Customer)
                .Include(a => a.PetService)
                .Include(a => a.ComboService)
                .Where(a => a.CompletedDate.HasValue)
                .OrderByDescending(a => a.CompletedDate)
                .Take(topCount)
                .ToListAsync();
        }

        public async Task<List<Appointment>> GetNextUpcomingAppointmentAsync(int topCount)
        {
            return await _context.Appointments
                .Include(a => a.Customer)
                .Include(a => a.PetService)
                .Include(a => a.ComboService)
                .Where(a => a.Status == "Accepted" && a.AppointmentDate > a.AcceptedDate)
                .OrderBy(a => a.AppointmentDate)
                .Take(topCount)
                .ToListAsync();
        }

        public Task<int> GetTotalAppointmentAsync()
        {
            throw new NotImplementedException();
        }

        //MANAGER
        public async Task<List<Appointment>> GetAllAppointmentsByDateAsync(int topCount)
        {
            return await _context.Appointments
                .Include(a => a.Customer)
                .Include(a => a.Pet)
                .Include(a => a.PetService)
                .Include(a => a.AppointmentVeterinarians)
                    .ThenInclude(av => av.Veterinarian)
                        .ThenInclude(u => u.User)
                .OrderByDescending(a => a.AppointmentDate)
                .Take(topCount)
                .ToListAsync();
        }

        public async Task<List<ServiceReport>> GetServiceReportsByDateAsync(int topCount)
        {
            return await _context.ServiceReports
                .Include(s => s.Appointment)
                .ThenInclude(a => a.Customer)
                .OrderByDescending(sr => sr.ReportDate)
                .Take(topCount)
                .ToListAsync();
        }

        public async Task<int> GetTotalCustomersAsync()
        {
            return await _context.Users.CountAsync(u => u.role == 5);
        }

        public async Task<int> GetTotalVeterinariansAsync()
        {
            return await _context.Users.CountAsync(u => u.role == 3);
        }

        public async Task<decimal> GetTotalPaymentsAsync()
        {
            return await _context.Payments.SumAsync(p => p.TotalAmount);
        }
    }
}

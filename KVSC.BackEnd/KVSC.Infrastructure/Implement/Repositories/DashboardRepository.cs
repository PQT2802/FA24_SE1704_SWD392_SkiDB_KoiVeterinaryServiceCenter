using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
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

    }
}

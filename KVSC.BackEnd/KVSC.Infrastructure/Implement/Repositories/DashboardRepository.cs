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

        public async Task<List<Veterinarian>> GetTopVeterinariansByAppointmentsAsync(int topCount)
        {
            return await _context.Veterinarians
                .OrderByDescending(v => v.AppointmentVeterinarians.Count)
                .Take(topCount)
                .ToListAsync();
        }

        public async Task<List<PetService>> GetBestServicesByRatingAsync(int topCount)
        {
            return await _context.PetServices
                .OrderByDescending(s => s.Ratings.Average(r => r.Score))
                .Take(topCount)
                .ToListAsync();
        }

        public async Task<List<Product>> GetTopSellingProductsAsync(int topCount)
        {
            return await _context.Products
                .OrderByDescending(p => p.OrderItems.Count)
                .Take(topCount)
                .ToListAsync();
        }
    }
}

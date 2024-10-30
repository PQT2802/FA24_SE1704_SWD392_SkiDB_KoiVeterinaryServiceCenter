using KVSC.Domain.Entities;
using KVSC.Infrastructure.Implement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IDashboardRepository
    {
        Task<List<Veterinarian>> GetTopVeterinariansByAppointmentsAsync(int topCount);
        Task<List<PetService>> GetBestServicesByRatingAsync(int topCount);
        Task<List<Product>> GetTopSellingProductsAsync(int topCount);
    }
}

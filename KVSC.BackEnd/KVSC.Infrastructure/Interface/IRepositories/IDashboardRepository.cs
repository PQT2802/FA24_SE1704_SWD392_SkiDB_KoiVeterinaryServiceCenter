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
        //ADMIN
        Task<List<Veterinarian>> GetTopVeterinariansByAppointmentsAsync(int topCount);
        Task<List<PetService>> GetBestServicesByRatingAsync(int topCount);
        Task<List<Product>> GetTopSellingProductsAsync(int topCount);
        Task<int> GetTotalUserAsync();

        //VET
        Task<List<Appointment>> GetNextUpcomingAppointmentAsync(int topCount);
        Task<List<Appointment>> GetNewestCompletedAppointmentAsync(int topCount);
        Task<int> GetTotalAppointmentAsync();

        //MANAGER
        Task<List<Appointment>> GetAllAppointmentsByDateAsync(int topCount);
        Task<List<ServiceReport>> GetServiceReportsByDateAsync(int topCount);

        Task<int> GetTotalCustomersAsync();
        Task<int> GetTotalVeterinariansAsync();
        Task<decimal> GetTotalPaymentsAsync();
    }
}

using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Dashboard.Admin;
using KVSC.Infrastructure.DTOs.Dashboard.Manager;
using KVSC.Infrastructure.DTOs.Dashboard.Vet;
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
        //MANAGER
        Task<int> GetTotalCustomersAsync();
        Task<int> GetTotalVeterinariansAsync();
        Task<int> GetTotalStaffAsync();
        Task<decimal> GetTotalPaymentsAsync();
        Task<Dictionary<string, int>> GetAllAppointmentAsync();
        Task<List<PetServiceTopBooking>> GetTopServicesByBookingsAsync();
        Task<List<PetServiceTopRating>> GetTopServicesByRatingAsync();
        Task<List<PetServiceTopCancellation>> GetTopServicesByCancellationsAsync();


        //CUSTOMER
        Task<int> GetCustomerPetAsync(Guid customerId);
        Task<int> GetCustomerAppointmentAsync(Guid customerId);
        Task<decimal> GetCustomerPaymentAsync(Guid customerId);
        Task<Dictionary<DateTime, int>> GetMonthlyCustomerAppointmentsAsync(Guid customerId, int months);
        Task<Dictionary<DateTime, decimal>> GetMonthlyCustomerPaymentsAsync(Guid customerId, int months);


        //VET
        Task<int> GetVeterinarianCustomersAsync(Guid veterinarianId); 
        Task<int> GetVeterinarianAppointmentAsync(Guid veterinarianId);
        Task<List<UpcomingAppointment>> GetNextUpcomingAppointmentAsync(Guid veterinarianId);
        Task<List<CompletedAppointment>> GetNewestCompletedAppointmentAsync(Guid veterinarianId);
        Task<List<PendingAppointment>> GetPendingAppointmentAsync();


        //ADMIN
        Task<int> GetTotalManagersAsync();
        Task<int> GetTotalUsersAsync();

    }
}

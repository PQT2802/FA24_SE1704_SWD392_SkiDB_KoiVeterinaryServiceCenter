﻿using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Dashboard.Manager;
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

        //VET
        Task<List<Appointment>> GetNextUpcomingAppointmentAsync();
        Task<List<Appointment>> GetNewestCompletedAppointmentAsync();
        Task<int> GetVetAppointmentAsync();

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

    }
}

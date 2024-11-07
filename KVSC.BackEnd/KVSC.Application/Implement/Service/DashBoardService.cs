using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Dashboard.Admin;
using KVSC.Infrastructure.DTOs.Dashboard.Customer;
using KVSC.Infrastructure.DTOs.Dashboard.Manager;
using KVSC.Infrastructure.DTOs.Dashboard.Vet;
using KVSC.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class DashBoardService : IDashBoardService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DashBoardService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        //MANAGER
        public async Task<Result> GetManagerDashboardDataAsync(Guid managerId)
        {
            var totalCustomers = await _unitOfWork.DashboardRepository.GetTotalCustomersAsync();
            var totalVeterinarians = await _unitOfWork.DashboardRepository.GetTotalVeterinariansAsync();
            var totalStaffs = await _unitOfWork.DashboardRepository.GetTotalStaffAsync();
            var totalPayments = await _unitOfWork.DashboardRepository.GetTotalPaymentsAsync();

            var appointmentStatusCounts = await _unitOfWork.DashboardRepository.GetAllAppointmentAsync();
            var topServicesByBookings = await _unitOfWork.DashboardRepository.GetTopServicesByBookingsAsync();
            var topServicesByRating = await _unitOfWork.DashboardRepository.GetTopServicesByRatingAsync();
            var topServicesByCancellations = await _unitOfWork.DashboardRepository.GetTopServicesByCancellationsAsync();

            var managerDashboard = new ManagerDashboardData
            {
                TotalCustomers = totalCustomers,
                TotalVeterinarians = totalVeterinarians,
                TotalStaffs = totalStaffs,
                TotalPayments = totalPayments,
                AppointmentStatusCounts = appointmentStatusCounts, 
                TopServicesByBookings = topServicesByBookings, 
                TopServicesByRating = topServicesByRating,  
                TopServicesByCancellations = topServicesByCancellations 
            };

            return Result.SuccessWithObject(managerDashboard);
        }

        //CUSTOMER
        public async Task<Result> GetCustomerDashboardDataAsync(Guid customerId)
        {
            var totalPets = await _unitOfWork.DashboardRepository.GetCustomerPetAsync(customerId);
            var totalAppointments = await _unitOfWork.DashboardRepository.GetCustomerAppointmentAsync(customerId);
            var totalPayments = await _unitOfWork.DashboardRepository.GetCustomerPaymentAsync(customerId);

            var monthlyAppointments = await _unitOfWork.DashboardRepository.GetMonthlyCustomerAppointmentsAsync(customerId, 12);
            var monthlyPayments = await _unitOfWork.DashboardRepository.GetMonthlyCustomerPaymentsAsync(customerId, 12);


            var customerDashboard = new CustomerDashboardData
            {
                TotalPets = totalPets,
                TotalAppointments = totalAppointments,
                TotalPayments = totalPayments,
                MonthlyAppointments = monthlyAppointments,
                MonthlyPayments = monthlyPayments
            };

            return Result.SuccessWithObject(customerDashboard);
        }



        //VET
        public async Task<Result> GetVeterinarianDashboardDataAsync(Guid veterinarianId)
        {
            var totalCustomers = await _unitOfWork.DashboardRepository.GetVeterinarianCustomersAsync(veterinarianId);
            var totalAppointments = await _unitOfWork.DashboardRepository.GetVeterinarianAppointmentAsync(veterinarianId);

            var upcomingAppointments = await _unitOfWork.DashboardRepository.GetNextUpcomingAppointmentAsync(veterinarianId);
            var completedAppointments = await _unitOfWork.DashboardRepository.GetNewestCompletedAppointmentAsync(veterinarianId);
            var pendingAppointments = await _unitOfWork.DashboardRepository.GetPendingAppointmentAsync();


            var vetDashboard = new VetDashboardData
            {
                TotalCustomers = totalCustomers,
                TotalAppointments = totalAppointments,
                UpcomingAppointment = upcomingAppointments,
                CompletedAppointment = completedAppointments,
                PendingAppointment = pendingAppointments
            };

            return Result.SuccessWithObject(vetDashboard);
        }


        //ADMIN
        public async Task<Result> GetAdminDashboardDataAsync(Guid adminId)
        {
            var totalUsers = await _unitOfWork.DashboardRepository.GetTotalUsersAsync();
            var totalCustomers = await _unitOfWork.DashboardRepository.GetTotalCustomersAsync();
            var totalVeterinarians = await _unitOfWork.DashboardRepository.GetTotalVeterinariansAsync();
            var totalStaff = await _unitOfWork.DashboardRepository.GetTotalStaffAsync();
            var totalManagers = await _unitOfWork.DashboardRepository.GetTotalManagersAsync();
            var totalPayments = await _unitOfWork.DashboardRepository.GetTotalPaymentsAsync();

            var adminDashboard = new AdminDashboardData
            {
                TotalUsers = totalUsers,
                TotalCustomers = totalCustomers,
                TotalVeterinarians = totalVeterinarians,
                TotalStaff = totalStaff,
                TotalManagers = totalManagers,
                TotalPayments = totalPayments
            };

            return Result.SuccessWithObject(adminDashboard);
        }
    }
}

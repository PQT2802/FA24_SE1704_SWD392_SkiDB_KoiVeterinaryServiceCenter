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

        //ADMIN
        public async Task<Result> GetDashboardDataAsync(int topCount = 5)
        {
            var topVeterinariansResult = await GetTopVeterinariansAsync(topCount);
            if (!topVeterinariansResult.IsSuccess) return topVeterinariansResult;

            var bestServicesResult = await GetBestServicesAsync(topCount);
            if (!bestServicesResult.IsSuccess) return bestServicesResult;

            var topProductsResult = await GetTopSellingProductsAsync(topCount);
            if (!topProductsResult.IsSuccess) return topProductsResult;

            var dashboardData = new AdminDashboardData
            {
                TopVeterinarians = topVeterinariansResult.Object as List<TopVeterinarian>,
                BestServices = bestServicesResult.Object as List<TopService>,
                TopSellingProducts = topProductsResult.Object as List<TopProduct>
            };

            return Result.SuccessWithObject(dashboardData);
        }

        public async Task<Result> GetTopVeterinariansAsync(int topCount)
        {
            var veterinarians = await _unitOfWork.DashboardRepository.GetTopVeterinariansByAppointmentsAsync(topCount);

            var veterinarianDtos = veterinarians.Select(v => new TopVeterinarian
            {
                Id = v.UserId,
                Name = v.User?.FullName,
                AppointmentCount = v.AppointmentVeterinarians?.Count ?? 0
            })
                .ToList();

            return Result.SuccessWithObject(veterinarianDtos);
        }


        public async Task<Result> GetBestServicesAsync(int topCount)
        {
            var services = await _unitOfWork.DashboardRepository.GetBestServicesByRatingAsync(topCount);
            var serviceDtos = services.Select(s => new TopService
            {
                Id = s.Id,
                Name = s.Name,
                AverageRating = s.Ratings.Any() ? (decimal)s.Ratings.Average(r => r.Score) : 0m
            }).ToList();
            return Result.SuccessWithObject(serviceDtos);
        }

        public async Task<Result> GetTopSellingProductsAsync(int topCount)
        {
            var products = await _unitOfWork.DashboardRepository.GetTopSellingProductsAsync(topCount);

            var productDtos = products.Select(p => new TopProduct
            {
                Id = p.Id,
                Name = p.Name,
                SoldQuantity = p.OrderItems?.Count ?? 0 
            }).ToList();

            return Result.SuccessWithObject(productDtos);
        }


        //VET
        public async Task<Result> GetVeterinarianDashboardDataAsync()
        {
            var newestCompletedAppointmentsResult = await GetNewestCompletedAppointmentsAsync();
            if (!newestCompletedAppointmentsResult.IsSuccess) return newestCompletedAppointmentsResult;

            var nextUpcomingAppointmentsResult = await GetNextUpcomingAppointmentsAsync();
            if (!nextUpcomingAppointmentsResult.IsSuccess) return nextUpcomingAppointmentsResult;

            var dashboardData = new VetDashboardData
            {
                NextUpcomingAppointment = nextUpcomingAppointmentsResult.Object as List<NextAppointment>,
                NewestCompletedAppointment = newestCompletedAppointmentsResult.Object as List<NewestAppointment>
            };

            return Result.SuccessWithObject(dashboardData);
        }

        public async Task<Result> GetNewestCompletedAppointmentsAsync()
        {
            var appointments = await _unitOfWork.DashboardRepository.GetNewestCompletedAppointmentAsync();
            var appointmentDtos = appointments.Select(a => new NewestAppointment
            {
                AppointmentId = a.Id,
                CustomerName = a.Customer.FullName,
                AppointmentDate = a.AppointmentDate,
                CompletedDate = a.CompletedDate,
                AcceptedDate = a.AcceptedDate
            }).ToList();

            return Result.SuccessWithObject(appointmentDtos);
        }

        public async Task<Result> GetNextUpcomingAppointmentsAsync()
        {
            var appointments = await _unitOfWork.DashboardRepository.GetNextUpcomingAppointmentAsync();
            var appointmentDtos = appointments.Select(a => new NextAppointment
            {
                AppointmentId = a.Id,
                CustomerName = a.Customer.FullName,
                AppointmentDate = a.AppointmentDate,
                AcceptedDate = a.AcceptedDate,
                ServiceName = a.PetService?.Name ?? a.ComboService?.Name
            }).ToList();

            return Result.SuccessWithObject(appointmentDtos);
        }

        //MANAGER
        public async Task<Result> GetManagerDashboardDataAsync()
        {

            var serviceReportsResult = await GetServiceReportsAsync();
            if (!serviceReportsResult.IsSuccess) return serviceReportsResult;

            var manageDetailResult = await GetManageDetailAsync();
            if (!manageDetailResult.IsSuccess) return manageDetailResult;

            var dashboardData = new ManagerDashboardData
            {
                ManageDetails = manageDetailResult.Object as ManageDetail,
                ServiceReportDetails = serviceReportsResult.Object as List<ServiceReportDetail>
            };

            return Result.SuccessWithObject(dashboardData);
        }

        public async Task<Result> GetServiceReportsAsync()
        {
            var serviceReports = await _unitOfWork.DashboardRepository.GetServiceReportsByDateAsync();

            var serviceReportDtos = serviceReports.Select(sr => new ServiceReportDetail
        {
            ReportId = sr.Id,
            ReportDate = sr.ReportDate,
            ReportContent = sr.ReportContent,
            AppointmentId = sr.AppointmentId, 
            CustomerName = sr.Appointment?.Customer?.FullName,
            VeterinarianName = sr.Appointment?.AppointmentVeterinarians?.FirstOrDefault()?.Veterinarian.User.FullName
            }).ToList();

            return Result.SuccessWithObject(serviceReportDtos);
        }

        public async Task<Result> GetManageDetailAsync()
        {
            var totalCustomers = await _unitOfWork.DashboardRepository.GetTotalCustomersAsync();
            var totalVeterinarians = await _unitOfWork.DashboardRepository.GetTotalVeterinariansAsync();
            var totalPayments = await _unitOfWork.DashboardRepository.GetTotalPaymentsAsync();

            var manageDetail = new ManageDetail
            {
                TotalCustomers = totalCustomers,
                TotalVeterinarians = totalVeterinarians,
                TotalPayments = totalPayments
            };

            return Result.SuccessWithObject(manageDetail);
        }

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
    }
}

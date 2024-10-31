using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Dashboard.Admin;
using KVSC.Infrastructure.DTOs.Dashboard.Manager;
using KVSC.Infrastructure.DTOs.Dashboard.Staff;
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
                SoldQuantity = p.OrderItems?.Count ?? 0 // Check if OrderItems is null
            }).ToList();

            return Result.SuccessWithObject(productDtos);
        }


        //VET
        public async Task<Result> GetVeterinarianDashboardDataAsync(int topCount = 5)
        {
            var newestCompletedAppointmentsResult = await GetNewestCompletedAppointmentsAsync(topCount);
            if (!newestCompletedAppointmentsResult.IsSuccess) return newestCompletedAppointmentsResult;

            var nextUpcomingAppointmentsResult = await GetNextUpcomingAppointmentsAsync(topCount);
            if (!nextUpcomingAppointmentsResult.IsSuccess) return nextUpcomingAppointmentsResult;

            var dashboardData = new VetDashboardData
            {
                NextUpcomingAppointment = nextUpcomingAppointmentsResult.Object as List<NextAppointment>,
                NewestCompletedAppointment = newestCompletedAppointmentsResult.Object as List<NewestAppointment>
            };

            return Result.SuccessWithObject(dashboardData);
        }

        public async Task<Result> GetNewestCompletedAppointmentsAsync(int topCount)
        {
            var appointments = await _unitOfWork.DashboardRepository.GetNewestCompletedAppointmentAsync(topCount);
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

        public async Task<Result> GetNextUpcomingAppointmentsAsync(int topCount)
        {
            var appointments = await _unitOfWork.DashboardRepository.GetNextUpcomingAppointmentAsync(topCount);
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

        public async Task<Result> GetManagerDashboardDataAsync(int topCount = 5)
        {
            var appointmentsResult = await GetAllAppointmentsAsync(topCount);
            if (!appointmentsResult.IsSuccess) return appointmentsResult;

            var serviceReportsResult = await GetServiceReportsAsync(topCount);
            if (!serviceReportsResult.IsSuccess) return serviceReportsResult;

            var dashboardData = new ManagerDashboardData
            {
                AppointmentDetails = appointmentsResult.Object as List<AppointmentDetail>,
                ServiceReportDetails = serviceReportsResult.Object as List<ServiceReportDetail>
            };

            return Result.SuccessWithObject(dashboardData);
        }

        public async Task<Result> GetAllAppointmentsAsync(int topCount)
        {
            var appointments = await _unitOfWork.DashboardRepository.GetAllAppointmentsByDateAsync(topCount);

            var appointmentDtos = appointments.Select(a => new AppointmentDetail
            {
                Id = a.Id,
                AppointmentDate = a.AppointmentDate,
                Status = a.Status,
                CustomerName = a.Customer?.FullName,
                PetServiceName = a.PetService?.Name
            }).ToList();

            return Result.SuccessWithObject(appointmentDtos);
        }

        public async Task<Result> GetServiceReportsAsync(int topCount)
        {
            var serviceReports = await _unitOfWork.DashboardRepository.GetServiceReportsByDateAsync(topCount);

            var serviceReportDtos = serviceReports.Select(sr => new ServiceReportDetail
            {
                Id = sr.Id,
                ReportDate = sr.ReportDate,
                ReportContent = sr.ReportContent,
                HasPrescription = sr.HasPrescription
            }).ToList();

            return Result.SuccessWithObject(serviceReportDtos);
        }

        //STAFF
        public async Task<Result> GetStaffDashboardDataAsync(int topCount = 5)
        {
            var productsResult = await GetProductsInStockAsync();
            if (!productsResult.IsSuccess) return productsResult;

            var ordersResult = await GetRecentOrdersAsync(topCount);
            if (!ordersResult.IsSuccess) return ordersResult;

            var dashboardData = new StaffDashboardData
            {
                ProductsInStock = productsResult.Object as List<ProductInStock>,
                RecentOrders = ordersResult.Object as List<OrderDataDetail>
            };

            return Result.SuccessWithObject(dashboardData);
        }

        public async Task<Result> GetProductsInStockAsync()
        {
            var products = await _unitOfWork.DashboardRepository.GetProductsInStockAsync();

            var productDtos = products.Select(p => new ProductInStock
            {
                Id = p.Id,
                Name = p.Name,
                StockQuantity = p.StockQuantity,
                ImageUrl = p.ImageUrl
            }).ToList();

            return Result.SuccessWithObject(productDtos);
        }

        public async Task<Result> GetRecentOrdersAsync(int topCount)
        {
            var orders = await _unitOfWork.DashboardRepository.GetRecentOrdersByDateAsync(topCount);

            var orderDtos = orders.Select(o => new OrderDataDetail
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                TotalPrice = o.TotalPrice,
                OrderStatus = o.OrderStatus,
                CustomerName = o.Customer?.FullName
            }).ToList();

            return Result.SuccessWithObject(orderDtos);
        }
    }
}

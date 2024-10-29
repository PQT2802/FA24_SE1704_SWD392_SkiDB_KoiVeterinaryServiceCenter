using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Dashboard.Admin;
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

        public async Task<Result> GetTopVeterinariansAsync(int topCount)
        {

            // Validate input if necessary (e.g., check if topCount is positive)
            if (topCount <= 0)
            {
                //return Result.Failure();
            }

            // Fetch top veterinarians
            var veterinarians = await _unitOfWork.DashboardRepository.GetTopVeterinariansByAppointmentsAsync(topCount);
            if (veterinarians == null || !veterinarians.Any())
            {
                //return Result.Failure();
            }

            // Map results if needed and return
            var veterinarianResults = veterinarians.Select(v => new TopVeterinarian
            {
                Id = v.Id,
                Name = v.User?.FullName ?? "Unknown",
                AppointmentCount = v.AppointmentVeterinarians.Count
            }).ToList();

            return Result.SuccessWithObject(veterinarianResults);
        }

        public async Task<Result> GetBestServicesAsync(int topCount)
        {
            if (topCount <= 0)
            {
                //return Result.Failure();
            }

            // Fetch best services
            var services = await _unitOfWork.DashboardRepository.GetBestServicesByRatingAsync(topCount);
            if (services == null || !services.Any())
            {
                //return Result.Failure();
            }

            var serviceResults = services.Select(s => new TopService
            {
                Id = s.Id,
                Name = s.Name,
                AverageRating = s.Ratings.Any() ? (decimal)s.Ratings.Average(r => r.Score) : 0m
            }).ToList();

            return Result.SuccessWithObject(serviceResults);
        }

        public async Task<Result> GetTopSellingProductsAsync(int topCount)
        {
            if (topCount <= 0)
            {
                //return Result.Failure();
            }

            // Fetch top-selling products
            var products = await _unitOfWork.DashboardRepository.GetTopSellingProductsAsync(topCount);
            if (products == null || !products.Any())
            {
                //return Result.Failure();
            }

            var productResults = products.Select(p => new TopProduct
            {
                Id = p.Id,
                Name = p.Name,
                SoldQuantity = p.OrderItems.Count
            }).ToList();

            return Result.SuccessWithObject(productResults);
        }
    }
}

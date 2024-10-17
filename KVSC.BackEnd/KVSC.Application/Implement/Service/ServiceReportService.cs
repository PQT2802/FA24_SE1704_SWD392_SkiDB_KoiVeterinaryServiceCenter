using FluentValidation;
using KVSC.Application.Interface.ICommon;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.ProductCategory.GetProductCategory;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;
using KVSC.Infrastructure.DTOs.ServiceReport.GetServiceReport;
using KVSC.Infrastructure.DTOs.ServiceReport.UpdateServiceReport;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class ServiceReportService : IServiceReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<AddServiceReportRequest> _addServiceReportRequestValidator;
        private readonly IValidator<UpdateServiceReportRequest> _updateServiceReportRequestValidator;

        public ServiceReportService(
            IUnitOfWork unitOfWork,
            IValidator<AddServiceReportRequest> addServiceReportRequestValidator,
            IValidator<UpdateServiceReportRequest> updateServiceReportRequestValidator
        )
        {
            _unitOfWork = unitOfWork;
            _addServiceReportRequestValidator = addServiceReportRequestValidator;
            _updateServiceReportRequestValidator = updateServiceReportRequestValidator;
        }

        // Create Service Report
        public async Task<Result> AddServiceReportAsync(AddServiceReportRequest addServiceReportRequest)
        {
            var validate = await _addServiceReportRequestValidator.ValidateAsync(addServiceReportRequest);
            if (!validate.IsValid)
            {
                var errors = validate.Errors.Select(e => (Error)e.CustomState).ToList();
                return Result.Failures(errors);
            }

            var appointmentExists = await _unitOfWork.AppointmentRepository.AppointmentExistsAsync(addServiceReportRequest.AppointmentId);
            if (!appointmentExists)
            {
                return Result.Failure(ServiceReportErrorMessage.AppointmentNotExist());
            }

            var serviceReport = new ServiceReport
            {
                AppointmentId = addServiceReportRequest.AppointmentId,
                ReportContent = addServiceReportRequest.ReportContent,
                ReportDate = addServiceReportRequest.ReportDate,
                Recommendations = addServiceReportRequest.Recommendations,
                HasPrescription = addServiceReportRequest.HasPrescription,
                PrescriptionId = addServiceReportRequest.PrescriptionId,
                IsCompleted = addServiceReportRequest.IsCompleted ?? false
            };

            var createResult = await _unitOfWork.ServiceReportRepository.CreateServiceReportAsync(serviceReport);
            if (createResult == 0) // 
            {
                return Result.Failure(ServiceReportErrorMessage.ReportCreationFailed());
            }

            return Result.SuccessWithObject(createResult);
        }

        // Read (Retrieve a ServiceReport by ID)
        public async Task<Result> GetServiceReportByIdAsync(Guid serviceReportId)
        {
            var serviceReport = await _unitOfWork.ServiceReportRepository.GetServiceReportByIdAsync(serviceReportId);
            if (serviceReport == null)
            {
                return Result.Failure(ServiceReportErrorMessage.ReportNotExist());
            }

            var serviceReportResponse = new GetServiceReportResponse
            {
                ServiceReportId = serviceReport.Id,
                AppointmentId = serviceReport.AppointmentId,
                ReportContent = serviceReport.ReportContent,
                ReportDate = serviceReport.ReportDate,
                Recommendations = serviceReport.Recommendations,
                HasPrescription = serviceReport.HasPrescription,
                PrescriptionId = serviceReport.PrescriptionId,
                IsCompleted = serviceReport.IsCompleted
            };

            return Result.SuccessWithObject(serviceReportResponse);
        }

        // Read (Retrieve all ServiceReports based on criteria)
        public async Task<Result> GetServiceReportsAsync(SearchServiceReportRequest request)
        {
            var serviceReports = await _unitOfWork.ServiceReportRepository.GetServiceReportsAsync(request);
            if (serviceReports == null || !serviceReports.Any())
            {
                return Result.Failure(ServiceReportErrorMessage.ReportNotFound());
            }

            return Result.SuccessWithObject(serviceReports);
        }

        // Update Service Report
        public async Task<Result> UpdateServiceReportAsync(UpdateServiceReportRequest updateServiceReportRequest)
        {
            var validate = await _updateServiceReportRequestValidator.ValidateAsync(updateServiceReportRequest);
            if (!validate.IsValid)
            {
                var errors = validate.Errors.Select(e => (Error)e.CustomState).ToList();
                return Result.Failures(errors);
            }

            var serviceReport = await _unitOfWork.ServiceReportRepository.GetServiceReportByIdAsync(updateServiceReportRequest.ServiceReportId);
            if (serviceReport == null)
            {
                return Result.Failure(ServiceReportErrorMessage.ReportNotExist());
            }

            // Update fields
            if (!string.IsNullOrEmpty(updateServiceReportRequest.ReportContent))
                serviceReport.ReportContent = updateServiceReportRequest.ReportContent;

            serviceReport.ReportDate = updateServiceReportRequest.ReportDate;
            serviceReport.Recommendations = updateServiceReportRequest.Recommendations;
            serviceReport.HasPrescription = updateServiceReportRequest.HasPrescription;
            serviceReport.PrescriptionId = updateServiceReportRequest.PrescriptionId;
            serviceReport.IsCompleted = updateServiceReportRequest.IsCompleted ?? serviceReport.IsCompleted;

            var updateResult = await _unitOfWork.ServiceReportRepository.UpdateServiceReportAsync(serviceReport);
            return updateResult == 0
                ? Result.Failure(ServiceReportErrorMessage.ReportUpdateFailed())
                : Result.Success();
        }

        // Delete Service Report
        public async Task<Result> DeleteServiceReportAsync(Guid serviceReportId)
        {
            var serviceReport = await _unitOfWork.ServiceReportRepository.GetServiceReportByIdAsync(serviceReportId);
            if (serviceReport == null)
            {
                return Result.Failure(ServiceReportErrorMessage.ReportNotExist());
            }

            var deleteResult = await _unitOfWork.ServiceReportRepository.RemoveServiceReportAsync(serviceReport);
            return deleteResult ? Result.Success() : Result.Failure(ServiceReportErrorMessage.ReportDeletionFailed());
        }
    }
}

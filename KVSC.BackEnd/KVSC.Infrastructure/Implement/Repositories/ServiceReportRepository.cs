using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.DTOs.ServiceReport.GetServiceReport;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class ServiceReportRepository : GenericRepository<ServiceReport>, IServiceReportRepository
    {
        public ServiceReportRepository(KVSCContext context) : base(context) { }

        // CREATE
        public async Task<int> CreateServiceReportAsync(ServiceReport serviceReport)
        {
            _context.ServiceReports.Add(serviceReport);
            
            return await _context.SaveChangesAsync();
        }

        // READ
        public async Task<IEnumerable<ServiceReport>> GetAllServiceReportsAsync()
        {
            return await _context.ServiceReports
            .Include(sr => sr.Appointment)
                .Where(sr => !sr.IsDeleted)
                .ToListAsync();
        }

        public async Task<ServiceReport> GetServiceReportByIdAsync(Guid reportId)
        {
            return await _context.ServiceReports
                .Include(sr => sr.Appointment)
                .FirstOrDefaultAsync(sr => sr.Id == reportId && !sr.IsDeleted);
        }

        // UPDATE
        public async Task<int> UpdateServiceReportAsync(ServiceReport serviceReport)
        {
            var existingReport = await _context.ServiceReports.FirstOrDefaultAsync(sr => sr.Id == serviceReport.Id && !sr.IsDeleted);
            if (existingReport == null)
            {
                throw new Exception("Service report does not exist.");
            }

            existingReport.ReportContent = serviceReport.ReportContent;
            existingReport.ReportDate = serviceReport.ReportDate;
            existingReport.Recommendations = serviceReport.Recommendations;
            existingReport.HasPrescription = serviceReport.HasPrescription;
            existingReport.PrescriptionId = serviceReport.PrescriptionId;
            existingReport.IsCompleted = serviceReport.IsCompleted;

            _context.ServiceReports.Update(existingReport);
            return await _context.SaveChangesAsync();
        }

        // DELETE
        public async Task<bool> DeleteServiceReportAsync(Guid reportId)
        {
            var serviceReport = await _context.ServiceReports.FirstOrDefaultAsync(sr => sr.Id == reportId && !sr.IsDeleted);
            if (serviceReport == null)
            {
                return false;
            }

            serviceReport.IsDeleted = true;
            _context.ServiceReports.Update(serviceReport);
            await _context.SaveChangesAsync();
            return true;
        }

        // Check if ServiceReport exists
        public async Task<bool> ServiceReportExistsAsync(Guid reportId)
        {
            return await _context.ServiceReports.AnyAsync(sr => sr.Id == reportId && !sr.IsDeleted);
        }
        public async Task<List<ServiceReport>> GetServiceReportsAsync(SearchServiceReportRequest request)
        {
            // Start querying ServiceReports
            var query = _context.ServiceReports.AsQueryable();

            // Filter by AppointmentId if provided
            if (request.AppointmentId.HasValue)
            {
                query = query.Where(sr => sr.AppointmentId == request.AppointmentId.Value);
            }

            // Filter by ReportDate range if provided
            if (request.ReportDateFrom.HasValue)
            {
                query = query.Where(sr => sr.ReportDate >= request.ReportDateFrom.Value);
            }

            if (request.ReportDateTo.HasValue)
            {
                query = query.Where(sr => sr.ReportDate <= request.ReportDateTo.Value);
            }

            // Filter by completion status if provided
            if (request.IsCompleted.HasValue)
            {
                query = query.Where(sr => sr.IsCompleted == request.IsCompleted.Value);
            }

            // Execute the query and retrieve the results
            var serviceReports = await query.ToListAsync();

            return serviceReports;
        }
        public async Task<bool> RemoveServiceReportAsync(ServiceReport serviceReport)
        {
            _context.ServiceReports.Remove(serviceReport);
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }
    }
}

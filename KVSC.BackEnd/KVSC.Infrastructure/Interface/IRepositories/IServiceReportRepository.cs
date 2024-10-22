using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.ServiceReport.GetServiceReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IServiceReportRepository
    {
        public  Task<int> CreateServiceReportAsync(ServiceReport serviceReport);
        public  Task<IEnumerable<ServiceReport>> GetAllServiceReportsAsync();
        public  Task<ServiceReport> GetServiceReportByIdAsync(Guid reportId);
        public  Task<int> UpdateServiceReportAsync(ServiceReport serviceReport);
        public  Task<bool> DeleteServiceReportAsync(Guid reportId);
        public  Task<bool> ServiceReportExistsAsync(Guid reportId);
        public Task<List<ServiceReport>> GetServiceReportsAsync(SearchServiceReportRequest request);
        public Task<bool> RemoveServiceReportAsync(ServiceReport serviceReport);
    }
}

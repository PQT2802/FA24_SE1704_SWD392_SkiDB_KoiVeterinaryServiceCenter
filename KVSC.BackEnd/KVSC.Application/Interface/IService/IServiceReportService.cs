using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;
using KVSC.Infrastructure.DTOs.ServiceReport.GetServiceReport;
using KVSC.Infrastructure.DTOs.ServiceReport.UpdateServiceReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IServiceReportService
    {
        Task<Result> AddServiceReportAsync(AddServiceReportRequest addServiceReportRequest);
        Task<Result> GetServiceReportByIdAsync(Guid serviceReportId);
        Task<Result> GetServiceReportsAsync(SearchServiceReportRequest request);
        Task<Result> UpdateServiceReportAsync(UpdateServiceReportRequest updateServiceReportRequest);
        Task<Result> DeleteServiceReportAsync(Guid serviceReportId);


    }
}

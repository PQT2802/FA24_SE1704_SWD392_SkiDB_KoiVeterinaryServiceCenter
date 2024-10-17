using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ServiceReport.GetServiceReport
{
    public class SearchServiceReportRequest
    {
        public Guid? AppointmentId { get; set; }
        public DateTime? ReportDateFrom { get; set; }
        public DateTime? ReportDateTo { get; set; }
        public bool? IsCompleted { get; set; }
    }
}

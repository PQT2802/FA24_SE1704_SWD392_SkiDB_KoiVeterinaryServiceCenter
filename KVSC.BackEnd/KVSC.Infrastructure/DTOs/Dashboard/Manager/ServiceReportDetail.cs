using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Manager
{
    public class ServiceReportDetail
    {
        public Guid Id { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportContent { get; set; }
        public bool HasPrescription { get; set; }
    }
}

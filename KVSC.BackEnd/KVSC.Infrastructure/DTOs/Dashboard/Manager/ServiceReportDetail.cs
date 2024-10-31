using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Manager
{
    public class ServiceReportDetail
    {
        public Guid ReportId { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportContent { get; set; }

        public Guid AppointmentId { get; set; }
        public string CustomerName { get; set; }
        public string VeterinarianName { get; set; }
    }
}

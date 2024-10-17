using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ProductCategory.GetProductCategory
{
    public class GetServiceReportResponse
    {
        public Guid ServiceReportId { get; set; }
        public Guid AppointmentId { get; set; }
        public string ReportContent { get; set; }
        public DateTime ReportDate { get; set; }
        public string Recommendations { get; set; }
        public bool HasPrescription { get; set; }
        public Guid? PrescriptionId { get; set; }
        public bool IsCompleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ServiceReport.UpdateServiceReport
{
    public class UpdateServiceReportRequest
    {
        public Guid ServiceReportId { get; set; } // ID of the report to be updated
        public string ReportContent { get; set; } // Updated report content
        public DateTime ReportDate { get; set; } // Date of the report
        public string Recommendations { get; set; } // Updated recommendations, if any
        public bool HasPrescription { get; set; } // Indicates if the report includes a prescription
        public Guid? PrescriptionId { get; set; } // Prescription ID, if any
        public bool? IsCompleted { get; set; } // Indicates if the report is completed
    }
}

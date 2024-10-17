using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport
{
    public class AddServiceReportRequest
    {
        public Guid AppointmentId { get; set; }         // Link to Appointment
        public string ReportContent { get; set; }       // Content of the report
        public DateTime ReportDate { get; set; }        // Date the report was created
        public string Recommendations { get; set; }     // Doctor's recommendations

        public bool HasPrescription { get; set; }       // Flag indicating if there is a prescription
        public Guid? PrescriptionId { get; set; }       // Optional Prescription ID (nullable)
        public bool? IsCompleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport
{
    public class AddServiceReportRequest
    {
        public Guid AppointmentId { get; set; }
        public string ReportContent { get; set; }
        public string Recommendations { get; set; }
        public bool HasPrescription { get; set; }
        public List<PrescriptionDetailRequest>? PrescriptionDetails { get; set; } = new List<PrescriptionDetailRequest>();
    }

    public class PrescriptionDetailRequest
    {
        public Guid MedicineId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

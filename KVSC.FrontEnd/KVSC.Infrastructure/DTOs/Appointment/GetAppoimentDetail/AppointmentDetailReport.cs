using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail
{
    public class AppointmentDetailReport
    {
        public string ReportContent { get; set; }

        public DateTime ReportDate { get; set; }

        public string Recommendations { get; set; }

        public List<PrescriptionDetails>? PrescriptionDetail { get; set; }
    }
    public class PrescriptionDetails
    {
        public string MedicineName { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}

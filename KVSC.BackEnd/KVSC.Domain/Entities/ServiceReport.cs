using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class ServiceReport : BaseEntity
    {
        public Guid AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }

        public string ReportContent { get; set; }
        public DateTime ReportDate { get; set; }
        public string Recommendations { get; set; }

        public bool HasPrescription { get; set; }
        public Guid? PrescriptionId { get; set; }
        public virtual Prescription? Prescription { get; set; }

        public bool IsCompleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class Prescription : BaseEntity
    {
        public DateTime PrescriptionDate { get; set; }
        public Guid? ServiceReportId { get; set; }
        public virtual ServiceReport ServiceReport { get; set; } // One-to-one relationship

        public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; set; }
    }
}

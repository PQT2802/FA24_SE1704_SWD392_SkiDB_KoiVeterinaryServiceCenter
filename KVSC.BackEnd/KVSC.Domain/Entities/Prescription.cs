using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class Prescription : BaseEntity
    {
        public Guid ReportId { get; set; }
        public virtual ServiceReport Report { get; set; }

        public DateTime PrescriptionDate { get; set; }
        public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; set; }
    }
}

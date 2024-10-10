using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class PrescriptionDetail
    {
        public Guid PrescriptionDetailId { get; set; }
        public Guid PrescriptionId { get; set; }
        public virtual Prescription Prescription { get; set; }

        public Guid MedicineId { get; set; }
        public virtual Product Medicine { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Product.GetProduct
{
    public class GetMedicines
    {
        public Guid MedicineId { get; set; }
        public string MedicineName { get; set; }
        public decimal Price { get; set; }
    }
}

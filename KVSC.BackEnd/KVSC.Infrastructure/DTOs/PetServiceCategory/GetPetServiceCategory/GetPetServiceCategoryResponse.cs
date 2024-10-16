using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.PetServiceCategory.GetPetServiceCategory
{
    public class GetPetServiceCategoryResponse
    {
        public Guid Id { get; set; } // Thêm thuộc tính Id
        public string Name { get; set; }
        public string Description { get; set; }
        public string ServiceType { get; set; }
        public string ApplicableTo { get; set; }
    }
}

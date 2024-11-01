using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.PetServiceCategory.UpdatePetServiceCategory
{
    public class UpdatePetServiceCategoryRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public string ServiceType { get; set; } 
        public string ApplicableTo { get; set; } 
        public bool IsOnline { get; set; }
    }
}

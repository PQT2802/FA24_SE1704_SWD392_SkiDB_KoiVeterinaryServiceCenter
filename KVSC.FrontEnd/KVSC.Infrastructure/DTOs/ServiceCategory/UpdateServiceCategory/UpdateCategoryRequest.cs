using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ServiceCategory.UpdateServiceCategory
{
    public class UpdateCategoryRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ServiceType { get; set; } = string.Empty;
        public string ApplicableTo { get; set; } = string.Empty;
    }

}

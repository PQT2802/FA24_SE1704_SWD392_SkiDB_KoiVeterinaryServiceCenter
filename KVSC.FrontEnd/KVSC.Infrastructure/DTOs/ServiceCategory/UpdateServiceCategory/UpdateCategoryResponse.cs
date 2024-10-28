using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ServiceCategory.UpdateServiceCategory
{
    public class UpdateCategoryResponse
    {
        public Extensions<UpdateCategoryData> Extensions { get; set; }
    }

    public class UpdateCategoryData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ServiceType { get; set; }
        public string ApplicableTo { get; set; }
    }
}

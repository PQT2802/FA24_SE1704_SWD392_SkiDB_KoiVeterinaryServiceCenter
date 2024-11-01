using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ServiceCategory.GetServiceCategory
{
    public class GetPetServiceCategoryResponse
    {
        public Extensions<GetPetServiceCategoryData> Extensions { get; set; }

    }
    public class GetPetServiceCategoryData
    {
        public Guid Id { get; set; } // Thuộc tính Id
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ServiceType { get; set; } = string.Empty;
        public string ApplicableTo { get; set; } = string.Empty;
        public bool IsOnline {  get; set; }
    }
}

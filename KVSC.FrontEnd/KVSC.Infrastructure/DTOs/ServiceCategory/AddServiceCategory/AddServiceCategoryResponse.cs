using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ServiceCategory.AddServiceCategory
{
    public class AddServiceCategoryResponse
    {
        public Extensions<AddServiceCategoryData> Extensions { get; set; }
    }
    public class AddServiceCategoryData
    {
        public Guid Id { get; set; }
    }
}

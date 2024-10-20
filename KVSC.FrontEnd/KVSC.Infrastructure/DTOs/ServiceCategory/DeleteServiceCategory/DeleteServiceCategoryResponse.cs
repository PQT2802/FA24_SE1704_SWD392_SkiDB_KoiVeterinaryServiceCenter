using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ServiceCategory.DeleteServiceCategory
{
    public class DeleteServiceCategoryResponse
    {
        public Extensions<DeleteServiceCategoryData> Extensions { get; set; }
    }

    public class DeleteServiceCategoryData
    {
        public Guid Id { get; set; }
    }
}

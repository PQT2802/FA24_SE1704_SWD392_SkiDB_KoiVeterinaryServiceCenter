using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.ServiceCategory.AddServiceCategory
{
    public class AddServiceCategoryRequest
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required]
        public string ServiceType { get; set; } = string.Empty;

        public string ApplicableTo { get; set; } = string.Empty;
        public bool IsOnline { get; set; } = false;
    }
}

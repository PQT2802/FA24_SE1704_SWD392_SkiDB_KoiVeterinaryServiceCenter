using KVSC.Infrastructure.DTOs.Service.AddService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Service.GetServiceDetail
{
    public class GetPetServiceResponse
    {
        public Extensions<AddServiceData> Extensions { get; set; }
      
    }
    public class AddServiceData
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }
        public string Duration { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public decimal TravelCost { get; set; }
        public string ServiceCategory { get; set; } = string.Empty;
        public Guid PetServiceCategoryId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Service.UpdateService
{
    public class UpdateServiceRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid PetServiceCategoryId { get; set; }
        public decimal BasePrice { get; set; }
        public string Duration { get; set; }
        public string ImageUrl { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public decimal TravelCost { get; set; }
    }
}

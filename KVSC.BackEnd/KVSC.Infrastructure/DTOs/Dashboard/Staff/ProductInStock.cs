﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Staff
{
    public class ProductInStock
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
    }
}

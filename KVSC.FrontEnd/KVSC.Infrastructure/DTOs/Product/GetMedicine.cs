﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Product
{
    public class GetMedicine
    {
        public Extensions<List<GetMedicineData>> Extensions { get; set; }
    }
    public class GetMedicineData
    {
        public Guid MedicineId { get; set; }
        public string MedicineName { get; set; }
    }
}
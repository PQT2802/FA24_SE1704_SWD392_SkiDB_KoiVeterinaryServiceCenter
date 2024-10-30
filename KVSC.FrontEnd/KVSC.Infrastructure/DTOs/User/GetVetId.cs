﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.User
{
    public class GetVetId
    {
        public Extensions<List<GetVetIdData>> Extensions { get; set; }
    }
    public class GetVetIdData
    {
        public Guid VeterinarianId { get; set; }
        public string VeterinarianName { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsAvailable { get; set; }
    }
}

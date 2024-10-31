﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Rating.AddRating
{
    public class RatingCreateRequest
    {
        public Guid ServiceId { get; set; }
        public Guid CustomerId { get; set; }
        public int Score { get; set; }  
        public string Feedback { get; set; } = string.Empty;
    }
}

﻿using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace KVSC.Infrastructure.DTOs.Rating
{
    public class RatingList
    {
        public Extensions<RatingData> Extensions { get; set; }

        public class RatingData
        {
            public List<Rating> Data { get; set; } = new List<Rating>();
            public int TotalCount { get; set; }
            public int PageNumber { get; set; }
            public int PageSize { get; set; }
        }
        public class Rating : IPropertyNameProvider
        {
            public Guid Id { get; set; }
            public Guid ServiceId { get; set; }
            public Guid CustomerId { get; set; }
            public int Score { get; set; }
            public string Feedback { get; set; }
            public string ServiceName { get; set; }
            public string CustomerName { get; set; }
            public DateTime CreatedDate { get; set; }

            public List<string> GetPropertyNames()
            {
                return new List<string> { nameof(CustomerName), nameof(ServiceName), nameof(Feedback), nameof(Score) };
            }
        }
    }
}

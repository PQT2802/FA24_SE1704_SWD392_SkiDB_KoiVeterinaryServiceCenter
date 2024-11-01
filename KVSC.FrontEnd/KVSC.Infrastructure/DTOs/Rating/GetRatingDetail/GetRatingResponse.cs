using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Rating.GetRatingDetail
{
    public class GetRatingResponse
    {
        public Extensions<List<GetRatingData>> Extensions { get; set; }
    }
    public class GetRatingData
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public Guid CustomerId { get; set; }
        public int Score { get; set; }
        public string Feedback { get; set; }
        public string ServiceName { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

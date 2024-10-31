using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Rating.AddRating
{
    public class RatingCreateResponse
    {
        public Extensions<RatingCreateResponseData> Extensions { get; set; }
    }
    public class RatingCreateResponseData
    {
        public Guid Id { get; set; }
    }
}

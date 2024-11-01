using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Rating.DeleteRating
{
    public class DeleteRatingResponse
    {
        public Extensions<DeleteRatingData> Extensions { get; set; }
    }
    public class DeleteRatingData
    {
        public Guid Id { get; set; }
    }
}

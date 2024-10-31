using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Rating;
using KVSC.Infrastructure.DTOs.Rating.AddRating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Repositories.Interface
{
    public interface IRatingRepository
    {
        Task<ResponseDto<RatingList>> GetAllRatingsByServiceId(Guid serviceId, int score, DateTime? createdDate, int pageNumber, int pageSize);
        Task<ResponseDto<RatingList>> GetManagerRatingList(string customerName, string feedback, int score, int pageNumber, int pageSize);
        Task<ResponseDto<RatingCreateResponse>> CreateRatingAsync(RatingCreateRequest ratingRequest);
    }
}

using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Rating;
using KVSC.Infrastructure.DTOs.Rating.AddRating;
using KVSC.Infrastructure.DTOs.Rating.DeleteRating;
using KVSC.Infrastructure.DTOs.Rating.GetRatingDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Interface
{
    public interface IRatingService
    {
        Task<ResponseDto<RatingList>> GetAllRatingsByServiceIdAsync(Guid serviceId, int score, DateTime? createdDate, int pageNumber, int pageSize);
        Task<ResponseDto<RatingCreateResponse>> CreateRatingAsync(RatingCreateRequest ratingRequest);
        Task<ResponseDto<RatingList>> GetManagerRatingList(Guid serviceId, int score, DateTime? createdDate, int pageNumber, int pageSize);
        Task<ResponseDto<RatingList>> GetAllRatings(int pageNumber, int pageSize);
        Task<ResponseDto<DeleteRatingResponse>> DeleteRating(DeleteRatingRequest request);
        Task<ResponseDto<GetRatingResponse>> GetRatingDetail(Guid serviceId);
    }
}

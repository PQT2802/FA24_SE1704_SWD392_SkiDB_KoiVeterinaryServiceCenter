using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Rating;
using KVSC.Infrastructure.DTOs.Rating.AddRating;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KVSC.Infrastructure.DTOs.Rating.RatingList;

namespace KVSC.Application.Service.Implement
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;
        public RatingService(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }
        public async Task<ResponseDto<RatingList>> GetAllRatingsByServiceIdAsync(Guid serviceId, int score, DateTime? createdDate, int pageNumber, int pageSize)
        {
            return await _ratingRepository.GetAllRatingsByServiceId(serviceId, score, createdDate, pageNumber, pageSize);
        }
        public async Task<ResponseDto<RatingList>> GetManagerRatingList(string customerName, string feedback, int score, int pageNumber, int pageSize)
        {
            return await _ratingRepository.GetManagerRatingList(customerName, feedback, score, pageNumber, pageSize);
        }
        public async Task<ResponseDto<RatingCreateResponse>> CreateRatingAsync(RatingCreateRequest ratingRequest)
        {
            return await _ratingRepository.CreateRatingAsync(ratingRequest);
        }
    }
}

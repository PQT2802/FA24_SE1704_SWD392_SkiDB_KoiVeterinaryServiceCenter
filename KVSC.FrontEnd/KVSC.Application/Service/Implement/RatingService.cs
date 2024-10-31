using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Rating;
using KVSC.Infrastructure.DTOs.Rating.DeleteRating;
using KVSC.Infrastructure.Repositories.Implement;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

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
        public async Task<ResponseDto<RatingList>> GetManagerRatingList(Guid serviceId, int score, DateTime? createdDate, int pageNumber, int pageSize)
        {
            return await _ratingRepository.GetManagerRatingList(serviceId, score, createdDate, pageNumber, pageSize);
        }
        public async Task<ResponseDto<RatingList>> GetAllRatings(int pageNumber, int pageSize)
        {
            return await _ratingRepository.GetAllRatings(pageNumber, pageSize);
        }

        public async Task<ResponseDto<DeleteRatingResponse>> DeleteRating(DeleteRatingRequest request)
        {
            var response = await _ratingRepository.DeleteRating(request);
            return response;
        }
    }
}

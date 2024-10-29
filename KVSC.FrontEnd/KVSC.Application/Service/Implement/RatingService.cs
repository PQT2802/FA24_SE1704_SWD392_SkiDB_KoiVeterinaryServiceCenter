using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Rating;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

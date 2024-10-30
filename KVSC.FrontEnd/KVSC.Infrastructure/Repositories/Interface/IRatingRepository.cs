using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Rating;
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
        Task<ResponseDto<RatingList>> GetManagerRatingList(Guid serviceId, int score, DateTime? createdDate, int pageNumber, int pageSize);
        Task<ResponseDto<RatingList>> GetAllRatings(int pageNumber, int pageSize);
    }
}

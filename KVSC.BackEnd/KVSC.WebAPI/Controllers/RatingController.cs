using Azure.Core;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.PetService.GetPetService;
using KVSC.Infrastructure.DTOs.Rating.AddRating;
using KVSC.Infrastructure.DTOs.Rating.GetRating;
using KVSC.Infrastructure.DTOs.Rating.UpdateRating;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [ApiController]
    [Route("api/rating")]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpPost]
        public async Task<IResult> CreateRating([FromBody] AddRatingRequest addRatingRequest)
        {
            Result result = await _ratingService.CreateRatingAsync(addRatingRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Rating created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("service")]
        public async Task<IResult> GetRatingsByService([FromQuery] GetRatingRequest request)
        {
            var result = await _ratingService.GetRatingsByServiceIdAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Rating retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("all/ratings")]
        public async Task<IResult> GetAllRatings([FromQuery] GetAllRatingsRequest request)
        {
            var result = await _ratingService.GetAllRatingsAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Ratings retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpPut]
        public async Task<IResult> UpdateRating([FromBody] UpdateRatingRequest updateRatingRequest)
        {
            Result result = await _ratingService.UpdateRatingAsync(updateRatingRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Rating updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        // DELETE: api/rating/{id}
        [HttpDelete]
        public async Task<IResult> DeleteRating([FromQuery] GetRatingRequest request)
        {
            Result result = await _ratingService.DeleteRatingAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Rating deleted successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }   
}

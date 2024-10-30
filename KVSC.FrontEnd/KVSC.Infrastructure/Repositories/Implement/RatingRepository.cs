using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Rating;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Repositories.Implement
{
    public class RatingRepository : IRatingRepository
    {
        private readonly HttpClient _httpClient;
        public RatingRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDto<RatingList>> GetAllRatingsByServiceId(Guid serviceId, int score, DateTime? createdDate, int pageNumber, int pageSize)
        {
            try
            {
                var url = $"api/rating/all/ratings?ServiceId={serviceId}&CreatedDate={createdDate:yyyy-MM-dd}&PageNumber={pageNumber}&PageSize={pageSize}";

                if (score > 0)
                {
                    url += $"&Score={score}";
                }
                // Chỉ thêm CreatedDate nếu nó có giá trị
                if (createdDate.HasValue)
                {
                    url += $"&CreatedDate={createdDate.Value:yyyy-MM-dd}";
                }

                var response = await _httpClient.GetAsync(url);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<RatingList>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred while fetching ratings."
                    };
                }

                // Nếu thành công, deserialize danh sách đánh giá
                var ratingList = await response.Content.ReadFromJsonAsync<RatingList>(options);

                return new ResponseDto<RatingList>
                {
                    IsSuccess = true,
                    Data = ratingList,
                    Message = "Get ratings successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<RatingList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<RatingList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<RatingList>> GetManagerRatingList(string customerName, string feedback, int score, int pageNumber, int pageSize)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/rating/all/ratings?customerName={customerName}&feedback={feedback}&score={score}&pageNumber={pageNumber}&pageSize={pageSize}");
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>(options);
                    return new ResponseDto<RatingList>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during fetching rating data."
                    };
                }

                var ratingList = await response.Content.ReadFromJsonAsync<RatingList>(options);
                return new ResponseDto<RatingList>
                {
                    IsSuccess = true,
                    Data = ratingList,
                    Message = "Rating data fetched successfully."
                };
            }
            catch (HttpRequestException ex)
            {
                return new ResponseDto<RatingList>
                {
                    IsSuccess = false,
                    Message = $"Request error: {ex.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<RatingList>
                {
                    IsSuccess = false,
                    Message = $"Unexpected error: {ex.Message}"
                };
            }
        }


    }
}

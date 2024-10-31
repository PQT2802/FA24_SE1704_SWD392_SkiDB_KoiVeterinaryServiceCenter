using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Rating;
using KVSC.Infrastructure.DTOs.Rating.DeleteRating;
using KVSC.Infrastructure.DTOs.Rating.GetRatingDetail;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public async Task<ResponseDto<RatingList>> GetManagerRatingList(Guid serviceId, int score, DateTime? createdDate, int pageNumber, int pageSize)
        {
            try
            {
                var url = $"api/rating/all/ratings?PageNumber={pageNumber}&PageSize={pageSize}";

                if (serviceId != Guid.Empty)
                {
                    url += $"&ServiceId={serviceId}";
                }

                if (score > 0)
                {
                    url += $"&Score={score}";
                }

                if (createdDate.HasValue)
                {
                    url += $"&CreatedDate={createdDate.Value:yyyy-MM-dd}";
                }

                var response = await _httpClient.GetAsync(url);

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

        public async Task<ResponseDto<RatingList>> GetAllRatings(int pageNumber, int pageSize)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/rating/all/ratings?PageNumber={pageNumber}&PageSize={pageSize}");
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>(options);
                    return new ResponseDto<RatingList>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during fetching all ratings."
                    };
                }

                var ratingList = await response.Content.ReadFromJsonAsync<RatingList>(options);
                return new ResponseDto<RatingList>
                {
                    IsSuccess = true,
                    Data = ratingList,
                    Message = "All ratings fetched successfully."
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

        public async Task<ResponseDto<DeleteRatingResponse>> DeleteRating(DeleteRatingRequest request)
        {
            try
            {
                var url = $"api/rating?Id={request.Id}";

                // Gửi yêu cầu DELETE với Id của rating
                var response = await _httpClient.DeleteAsync(url);

                // Kiểm tra phản hồi từ server
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent);

                    return new ResponseDto<DeleteRatingResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during deletion."
                    };
                }

                return new ResponseDto<DeleteRatingResponse>
                {
                    IsSuccess = true,
                    Data = null,
                    Message = "Delete rating successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<DeleteRatingResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<DeleteRatingResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<GetRatingResponse>> GetRatingDetail(Guid serviceId)
        {
            try
            {
                // Send the request and get the response
                var response = await _httpClient.GetAsync($"api/rating/service?Id={serviceId}");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Check if the response indicates failure
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the error response using the options for case insensitivity
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<GetRatingResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get infor."
                    };
                }

                // If successful, deserialize the UserInfo response
                var userInfo = await response.Content.ReadFromJsonAsync<GetRatingResponse>(options);
                Console.WriteLine(JsonSerializer.Serialize(userInfo, new JsonSerializerOptions { WriteIndented = true }));

                return new ResponseDto<GetRatingResponse>
                {
                    IsSuccess = true,
                    Data = userInfo,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<GetRatingResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<GetRatingResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
    }
}

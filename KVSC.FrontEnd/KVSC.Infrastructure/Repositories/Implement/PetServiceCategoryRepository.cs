using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.AddServiceCategory;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Repositories.Implement
{
    public class PetServiceCategoryRepository : IPetServiceCategoryRepository
    {
        private readonly HttpClient _httpClient;
        public PetServiceCategoryRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //public async Task<ResponseDto<AddServiceCategoryResponse>> AddPetServiceCategory(AddServiceCategoryResponse request)
        //{

        //}

        public async Task<ResponseDto<KoiServiceCategoryList>> GetKoiServiceCategoryList()
        {
            try
            {

                // Send the request and get the response
                var response = await _httpClient.GetAsync("api/PetServiceCategory/all");

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

                    return new ResponseDto<KoiServiceCategoryList>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get infor."
                    };
                }

                // If successful, deserialize the UserInfo response
                var koiServiceCategoryList = await response.Content.ReadFromJsonAsync<KoiServiceCategoryList>(options);

                return new ResponseDto<KoiServiceCategoryList>
                {
                    IsSuccess = true,
                    Data = koiServiceCategoryList,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<KoiServiceCategoryList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<KoiServiceCategoryList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<KoiServiceCategory>> GetKoiServiceCategory()
        {
            try
            {

                // Send the request and get the response
                var response = await _httpClient.GetAsync("api/PetServiceCategory/all");

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

                    return new ResponseDto<KoiServiceCategory>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get infor."
                    };
                }

                // If successful, deserialize the UserInfo response
                var koiServiceCategoryList = await response.Content.ReadFromJsonAsync<KoiServiceCategory>(options);

                return new ResponseDto<KoiServiceCategory>
                {
                    IsSuccess = true,
                    Data = koiServiceCategoryList,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<KoiServiceCategory>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<KoiServiceCategory>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
    }
}

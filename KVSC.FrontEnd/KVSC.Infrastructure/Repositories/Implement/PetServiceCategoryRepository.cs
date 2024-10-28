using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.ServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.AddServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.DeleteServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.GetServiceCategory;
using KVSC.Infrastructure.DTOs.ServiceCategory.UpdateServiceCategory;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public async Task<ResponseDto<AddServiceCategoryResponse>> CreateCategoryAsync(AddServiceCategoryRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/PetServiceCategory", request);

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(errorContent, options);

                    return new ResponseDto<AddServiceCategoryResponse>
                    {
                        IsSuccess = false,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "Failed to create category."
                    };
                }

                var categoryResponse = await response.Content.ReadFromJsonAsync<AddServiceCategoryResponse>(options);

                return new ResponseDto<AddServiceCategoryResponse>
                {
                    IsSuccess = true,
                    Data = categoryResponse,
                    Message = "Category created successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<AddServiceCategoryResponse>
                {
                    IsSuccess = false,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<AddServiceCategoryResponse>
                {
                    IsSuccess = false,
                    Message = $"Unexpected error: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<UpdateCategoryResponse>> UpdateCategory(UpdateCategoryRequest request)
        {
            try
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var response = await _httpClient.PutAsJsonAsync("api/PetServiceCategory", request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<UpdateCategoryResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during updating."
                    };
                }

                var updateResponse = await response.Content.ReadFromJsonAsync<UpdateCategoryResponse>(options);

                return new ResponseDto<UpdateCategoryResponse>
                {
                    IsSuccess = true,
                    Data = updateResponse,
                    Message = "Update category successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<UpdateCategoryResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<UpdateCategoryResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<DeleteServiceCategoryResponse>> DeleteServiceCategory(DeleteServiceCategoryRequest request)
        {
            try
            {
                var url = $"api/PetServiceCategory?Id={request.Id}";

                var response = await _httpClient.DeleteAsync(url);

                if (response.StatusCode != System.Net.HttpStatusCode.OK) 
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent);

                    return new ResponseDto<DeleteServiceCategoryResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during deletion."
                    };
                }

                return new ResponseDto<DeleteServiceCategoryResponse>
                {
                    IsSuccess = true,
                    Data = null,
                    Message = "Delete service category successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<DeleteServiceCategoryResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<DeleteServiceCategoryResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<GetPetServiceCategoryResponse>> GetPetServiceCategoryDetail(Guid id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/PetServiceCategory?Id={id}");

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<GetPetServiceCategoryResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get info."
                    };
                }

                var petServiceCategory = await response.Content.ReadFromJsonAsync<GetPetServiceCategoryResponse>(options);

                return new ResponseDto<GetPetServiceCategoryResponse>
                {
                    IsSuccess = true,
                    Data = petServiceCategory,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<GetPetServiceCategoryResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<GetPetServiceCategoryResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
    }
}

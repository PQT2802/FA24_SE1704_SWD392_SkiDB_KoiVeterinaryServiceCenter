using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.AddService;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Repositories.Implement
{
    public class PetServiceRepository : IPetServiceRepository
    {
        private readonly HttpClient _httpClient;
        public PetServiceRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDto<AddServiceResponse>> AddPetService(AddServiceRequest request)
        {
            try
            {
                // Send the request and get the response
                var response = await _httpClient.PostAsJsonAsync("api/PetService", request);

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

                    return new ResponseDto<AddServiceResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during adding."
                    };
                }

                // If successful, deserialize the login response
                var addingResponse = await response.Content.ReadFromJsonAsync<AddServiceResponse>(options);

                return new ResponseDto<AddServiceResponse>
                {
                    IsSuccess = true,
                    Data = addingResponse,
                    Message = "Add service successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<AddServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<AddServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<KoiServiceList>> GetKoiServiceList()
        {
            try
            {

                // Send the request and get the response
                var response = await _httpClient.GetAsync("api/PetService");

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

                    return new ResponseDto<KoiServiceList>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get infor."
                    };
                }

                // If successful, deserialize the UserInfo response
                var koiServiceList = await response.Content.ReadFromJsonAsync<KoiServiceList>(options);

                return new ResponseDto<KoiServiceList>
                {
                    IsSuccess = true,
                    Data = koiServiceList,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<KoiServiceList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<KoiServiceList>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }


    }
}

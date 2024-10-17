using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.AddService;

using KVSC.Infrastructure.DTOs.Service.DeleteService;
using KVSC.Infrastructure.DTOs.Service.UpdateService;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.DTOs.User.Register;

using KVSC.Infrastructure.Repositories.Interface;
using System.Net.Http.Json;
using System.Text.Json;

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
        public async Task<ResponseDto<UpdateServiceResponse>> UpdatePetService(UpdateServiceRequest request)
        {
            try
            {

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Gọi API PUT với dữ liệu request
                var response = await _httpClient.PutAsJsonAsync("api/PetService", request);

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize lỗi trả về từ API
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<UpdateServiceResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during updating."
                    };
                }

                // Nếu thành công, lấy dữ liệu phản hồi
                var updateResponse = await response.Content.ReadFromJsonAsync<UpdateServiceResponse>(options);

                return new ResponseDto<UpdateServiceResponse>
                {
                    IsSuccess = true,
                    Data = updateResponse,
                    Message = "Update service successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<UpdateServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<UpdateServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
        public async Task<ResponseDto<DeleteServiceResponse>> DeletePetService(DeleteServiceRequest request)
        {
            try
            {
                var url = $"api/PetService?Id={request.Id}";

                // Call the API DELETE with the service ID in the URL
                var response = await _httpClient.DeleteAsync(url);

                if (response.StatusCode != System.Net.HttpStatusCode.OK) // Kiểm tra mã trạng thái
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize lỗi trả về từ API
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent);

                    return new ResponseDto<DeleteServiceResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during deletion."
                    };
                }

                // Nếu thành công, trả về thông điệp thành công
                return new ResponseDto<DeleteServiceResponse>
                {
                    IsSuccess = true,
                    Data = null,
                    Message = "Delete service successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<DeleteServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<DeleteServiceResponse>
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
                var response = await _httpClient.GetAsync("api/PetService/all");

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

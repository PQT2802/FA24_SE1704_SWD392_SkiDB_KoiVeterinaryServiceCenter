using KVSC.Infrastructure.DTOs.Dashboard.Customer;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Dashboard.Manager;
using KVSC.Infrastructure.DTOs.Dashboard.Veterinarian;
using KVSC.Infrastructure.DTOs.Dashboard.Admin;

namespace KVSC.Infrastructure.Repositories.Implement
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly HttpClient _httpClient;

        public DashboardRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDto<GetCusDashboardResponse>> GetCustomerDashboardAsync(Guid customerId)
        {
            try
            {
                // Gửi request và nhận phản hồi từ API
                var response = await _httpClient.GetAsync($"api/Dashboard/CustomerDashboard/{customerId}");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Kiểm tra nếu response có trạng thái không thành công
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize phản hồi lỗi với các option không phân biệt chữ hoa/thường
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<GetCusDashboardResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get information."
                    };
                }

                // Nếu thành công, deserialize nội dung phản hồi vào GetCusDashboardResponse
                var dashboardData = await response.Content.ReadFromJsonAsync<GetCusDashboardResponse>(options);

                return new ResponseDto<GetCusDashboardResponse>
                {
                    IsSuccess = true,
                    Data = dashboardData,
                    Message = "Get data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Xử lý lỗi yêu cầu HTTP (VD: lỗi mạng)
                return new ResponseDto<GetCusDashboardResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ khác
                return new ResponseDto<GetCusDashboardResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<GetManagerDashboardResponse>> GetManagerDashboardAsync(Guid managerId)
        {
            try
            {
                // Gửi request và nhận phản hồi từ API
                var response = await _httpClient.GetAsync($"api/Dashboard/ManagerDashboard/{managerId}");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Kiểm tra nếu response có trạng thái không thành công
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize phản hồi lỗi với các option không phân biệt chữ hoa/thường
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<GetManagerDashboardResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during get manager information."
                    };
                }

                // Nếu thành công, deserialize nội dung phản hồi vào GetManagerDashboardResponse
                var dashboardData = await response.Content.ReadFromJsonAsync<GetManagerDashboardResponse>(options);

                return new ResponseDto<GetManagerDashboardResponse>
                {
                    IsSuccess = true,
                    Data = dashboardData,
                    Message = "Get manager dashboard data successful."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Xử lý lỗi yêu cầu HTTP (VD: lỗi mạng)
                return new ResponseDto<GetManagerDashboardResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ khác
                return new ResponseDto<GetManagerDashboardResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<GetVetDashboardResponse>> GetVetDashboardAsync(Guid veterinarianId)
        {
            try
            {
                // Send request and receive response from the API
                var response = await _httpClient.GetAsync($"api/Dashboard/VeterinarianDashboard/{veterinarianId}");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Check if the response indicates a failure
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<GetVetDashboardResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred while retrieving veterinarian dashboard data."
                    };
                }

                // On success, deserialize the response content into GetVetDashboardResponse
                var dashboardData = await response.Content.ReadFromJsonAsync<GetVetDashboardResponse>(options);

                return new ResponseDto<GetVetDashboardResponse>
                {
                    IsSuccess = true,
                    Data = dashboardData,
                    Message = "Veterinarian dashboard data retrieved successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handle HTTP request errors (e.g., network issues)
                return new ResponseDto<GetVetDashboardResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handle other unexpected exceptions
                return new ResponseDto<GetVetDashboardResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<GetAdminDashboardResponse>> GetAdminDashboardAsync(Guid adminId)
        {
            try
            {
                // Send request and receive response from the API
                var response = await _httpClient.GetAsync($"api/Dashboard/AdminDashboard/{adminId}");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Check if the response indicates a failure
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<GetAdminDashboardResponse>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred while retrieving veterinarian dashboard data."
                    };
                }

                // On success, deserialize the response content into GetVetDashboardResponse
                var dashboardData = await response.Content.ReadFromJsonAsync<GetAdminDashboardResponse>(options);

                return new ResponseDto<GetAdminDashboardResponse>
                {
                    IsSuccess = true,
                    Data = dashboardData,
                    Message = "Veterinarian dashboard data retrieved successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handle HTTP request errors (e.g., network issues)
                return new ResponseDto<GetAdminDashboardResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handle other unexpected exceptions
                return new ResponseDto<GetAdminDashboardResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
    }
}

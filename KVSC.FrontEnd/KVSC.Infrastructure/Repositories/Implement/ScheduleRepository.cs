using KVSC.Infrastructure.DTOs.VeterinarianSchedule;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using KVSC.Infrastructure.DTOs.Service.AddService;

namespace KVSC.Infrastructure.Repositories.Implement
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly HttpClient _httpClient;
        public ScheduleRepository(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }
        public async Task<ResponseDto<bool>> RegisterShift(RegisterShiftRequest request,string token)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var content = JsonContent.Create(request);
                var response = await _httpClient.PostAsync("https://localhost:7283/api/VeterinarianSchedule/register", content);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the error response using the options for case insensitivity
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<bool>
                    {
                        IsSuccess = false,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "Failed to register the shift."
                    };
                }

                return new ResponseDto<bool> { IsSuccess = true, Data = true, Message = "Shift registered successfully." };
            }
            catch (Exception ex)
            {
                return new ResponseDto<bool>
                {
                    IsSuccess = false,
                    Message = $"An error occurred: {ex.Message}"
                };
            }
        }

        public async Task<ResponseDto<ScheduleDto>> GetWeeklySchedule(DateTime currentDay, string token)
        {
            try
            {
                // Thiết lập Authorization header
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var url = $"https://localhost:7283/api/VeterinarianSchedule/weekly?currentDay={currentDay:MM/dd}";
                var response = await _httpClient.GetAsync(url);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the error response using the options for case insensitivity
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<ScheduleDto>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during register."
                    };
                }
                // If successful, deserialize the login response
                var scheduleList = await response.Content.ReadFromJsonAsync<ScheduleDto>(options);
                return new ResponseDto<ScheduleDto>
                {
                    IsSuccess = true,
                    Data = scheduleList,
                    Message = "Schedule loaded successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                // Handling HTTP request exceptions (e.g., network errors)
                return new ResponseDto<ScheduleDto>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                return new ResponseDto<ScheduleDto>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
    }
}

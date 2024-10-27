﻿using KVSC.Infrastructure.DTOs.VeterinarianSchedule;
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
                TimeSpan startTime = TimeSpan.Parse(request.StartTime);
                TimeSpan endTime = TimeSpan.Parse(request.EndTime);
                var registerScheduleRequest = new RegisterScheduleRequest
                {
                    Date = request.Date,
                    StartTime = startTime,
                    EndTime = endTime
                };
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await _httpClient.PostAsJsonAsync("api/VeterinarianSchedule/register", registerScheduleRequest);
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
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var url = $"https://localhost:7283/api/VeterinarianSchedule/all-weekly?currentDay={currentDay}";
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
                // Deserialize tạm thời với TemporaryScheduleDto
                var tempScheduleData = await response.Content.ReadFromJsonAsync<TemporaryScheduleDto>(options);

                // Chuyển đổi TemporaryScheduleDto thành ScheduleDto
                var convertedData = new ScheduleDto
                {
                    Extensions = new Extensions<List<ScheduleDtoData>>
                    {
                        Data = new List<ScheduleDtoData>()
                    }
                };
                var shifts = new List<Shift>
                {
                    new Shift { ShiftName = "Morning", StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(12, 0, 0) },
                    new Shift { ShiftName = "Afternoon", StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(17, 0, 0) },
                    new Shift { ShiftName = "Evening", StartTime = new TimeSpan(17, 0, 0), EndTime = new TimeSpan(21, 0, 0) }
                };

                foreach (var kvp in tempScheduleData.Extensions.Data)
                {
                    foreach (var v in kvp.Value)
                    {
                        var shiftName = shifts.FirstOrDefault(shift =>
                            TimeSpan.Parse(v.StartTime) == shift.StartTime &&
                            TimeSpan.Parse(v.EndTime) == shift.EndTime);

                        if (shiftName != null)
                        {
                            convertedData.Extensions.Data.Add(new ScheduleDtoData
                            {
                                Date = v.Date,
                                StartTime = v.StartTime,
                                EndTime = v.EndTime,
                                IsAvailable = v.IsAvailable,
                                VeterinarianName = v.VeterinarianName,
                                VeterinarianId = v.VeterinarianId,
                                Shift = shiftName.ShiftName // Thêm ca làm việc
                            });
                        }
                    }
                }

                return new ResponseDto<ScheduleDto>
                {
                    IsSuccess = true,
                    Data = convertedData,
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

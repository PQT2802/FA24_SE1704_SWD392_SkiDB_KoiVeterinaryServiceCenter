using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.DTOs.User.Login;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly HttpClient _httpClient;

    public AppointmentRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ResponseDto<GetAppointmentDetailResponse>> GetAppointmentDetail(Guid appointmentId)
    {
        try
        {

            // Send the request and get the response
            var response = await _httpClient.GetAsync($"api/Appointment/detail/{appointmentId}");

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

                return new ResponseDto<GetAppointmentDetailResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                    Message = "An error occurred during get infor."
                };
            }

            // If successful, deserialize the UserInfo response
            var detail = await response.Content.ReadFromJsonAsync<GetAppointmentDetailResponse>(options);

            return new ResponseDto<GetAppointmentDetailResponse>
            {
                IsSuccess = true,
                Data = detail,
                Message = "Get data successful."
            };
        }
        catch (HttpRequestException httpEx)
        {
            // Handling HTTP request exceptions (e.g., network errors)
            return new ResponseDto<GetAppointmentDetailResponse>
            {
                IsSuccess = false,
                Data = null,
                Message = $"Request error: {httpEx.Message}"
            };
        }
        catch (Exception ex)
        {
            // Handling any other exceptions
            return new ResponseDto<GetAppointmentDetailResponse>
            {
                IsSuccess = false,
                Data = null,
                Message = $"An unexpected error occurred: {ex.Message}"
            };
        }
    }
    
    

    public async Task<ResponseDto<AppointmentList>> GetAppoitmentListForVet(string token)
    {
        try
        {
            // Set the request with authorization token in headers
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // Send the request and get the response
            var response = await _httpClient.GetAsync("api/Appointment/list/vet");

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

                return new ResponseDto<AppointmentList>
                {
                    IsSuccess = false,
                    Data = null,
                    Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                    Message = "An error occurred during get infor."
                };
            }

            // If successful, deserialize the UserInfo response
            var appointmentList = await response.Content.ReadFromJsonAsync<AppointmentList>(options);

            return new ResponseDto<AppointmentList>
            {
                IsSuccess = true,
                Data = appointmentList,
                Message = "Get data successful."
            };
        }
        catch (HttpRequestException httpEx)
        {
            // Handling HTTP request exceptions (e.g., network errors)
            return new ResponseDto<AppointmentList>
            {
                IsSuccess = false,
                Data = null,
                Message = $"Request error: {httpEx.Message}"
            };
        }
        catch (Exception ex)
        {
            // Handling any other exceptions
            return new ResponseDto<AppointmentList>
            {
                IsSuccess = false,
                Data = null,
                Message = $"An unexpected error occurred: {ex.Message}"
            };
        }
    }
    
    public async Task<ResponseDto<AppointmentList>> GetAppointmentListForCustomer(string token)
{
    try
    {
        // Set the authorization token in the headers
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        // Send the HTTP request to get customer-specific appointment data
        var response = await _httpClient.GetAsync("/api/Appointment/list/customer");

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

            return new ResponseDto<AppointmentList>
            {
                IsSuccess = false,
                Data = null,
                Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                Message = "An error occurred while fetching customer appointments."
            };
        }

        // If successful, deserialize the appointment list response
        var appointmentList = await response.Content.ReadFromJsonAsync<AppointmentList>(options);

        return new ResponseDto<AppointmentList>
        {
            IsSuccess = true,
            Data = appointmentList,
            Message = "Data retrieved successfully."
        };
    }
    catch (HttpRequestException httpEx)
    {
        // Handle HTTP request exceptions (e.g., network errors)
        return new ResponseDto<AppointmentList>
        {
            IsSuccess = false,
            Data = null,
            Message = $"Request error: {httpEx.Message}"
        };
    }
    catch (Exception ex)
    {
        // Handle any other exceptions
        return new ResponseDto<AppointmentList>
        {
            IsSuccess = false,
            Data = null,
            Message = $"An unexpected error occurred: {ex.Message}"
        };
    }
}


    

    public async Task<ResponseDto<MakeAppointmentForServiceRequest>> MakeAppointmentForServiceAsync(MakeAppointmentForServiceRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync("api/appointment/service", request);

        // Deserialize the response into ResponseDto
        if (response.IsSuccessStatusCode)
        {
            var successResult = await response.Content.ReadFromJsonAsync<ResponseDto<MakeAppointmentForServiceRequest>>();
            return successResult;
        }
        else
        {
            var errorResult = await response.Content.ReadFromJsonAsync<ResponseDto<MakeAppointmentForServiceRequest>>();
            return new ResponseDto<MakeAppointmentForServiceRequest>
            {
                IsSuccess = false,
                Message = errorResult?.Message ?? "Failed to create the appointment",
                Errors = errorResult?.Errors ?? new List<ErrorDetail>()
            };
        }
    }

    public async Task<ResponseDto<UpdateStatusResponse>> UpdateAppointmentStatusAsync(Guid appointmentId, string status)
    {
        try
        {
            // Create the request body with the appointmentId and status
            var requestBody = new { AppointmentId = appointmentId, Status = status };

            // Send the request using the PUT method and pass the requestBody
            var response = await _httpClient.PutAsJsonAsync("api/Appointment/update", requestBody);

            // Configure options for case-insensitive deserialization
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // Check if the response indicates failure
            if (!response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();

                // Deserialize the error response using the options for case insensitivity
                var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                return new ResponseDto<UpdateStatusResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                    Message = "An error occurred while updating the appointment status."
                };
            }

            // If successful, deserialize the response content
            var updateResponse = await response.Content.ReadFromJsonAsync<UpdateStatusResponse>(options);

            // Return a success response with the deserialized data
            return new ResponseDto<UpdateStatusResponse>
            {
                IsSuccess = true,
                Data = updateResponse,
                Message = "Appointment status updated successfully."
            };
        }
        catch (HttpRequestException httpEx)
        {
            // Handling HTTP request exceptions (e.g., network errors)
            return new ResponseDto<UpdateStatusResponse>
            {
                IsSuccess = false,
                Data = null,
                Message = $"Request error: {httpEx.Message}"
            };
        }
        catch (Exception ex)
        {
            // Handling any other exceptions
            return new ResponseDto<UpdateStatusResponse>
            {
                IsSuccess = false,
                Data = null,
                Message = $"An unexpected error occurred: {ex.Message}"
            };
        }
    }
}
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.AppointmentForm;
using System.Net.Http.Json;
using System.Text.Json;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly HttpClient _httpClient;

    public AppointmentRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ResponseDto<MakeAppointmentForServiceResponse>> MakeAppointmentAsync(MakeAppointmentForServiceRequest request)
    {
        try
        {
            // Send the request and get the response
            var response = await _httpClient.PostAsJsonAsync("api/Appointment/appointment", request);

            /// must have
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

                return new ResponseDto<MakeAppointmentForServiceResponse>
                {
                    IsSuccess = false,
                    Data = null,
                    Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                    Message = "An error occurred during sign-in."
                };
            }

            // If successful, deserialize the login response
            var loginResponse = await response.Content.ReadFromJsonAsync<MakeAppointmentForServiceResponse>(options);

            return new ResponseDto<MakeAppointmentForServiceResponse>
            {
                IsSuccess = true,
                Data = loginResponse,
                Message = "Sign-in successful."
            };
        }
        catch (HttpRequestException httpEx)
        {
            // Handling HTTP request exceptions (e.g., network errors)
            return new ResponseDto<MakeAppointmentForServiceResponse>
            {
                IsSuccess = false,
                Data = null,
                Message = $"Request error: {httpEx.Message}"
            };
        }
        catch (Exception ex)
        {
            // Handling any other exceptions
            return new ResponseDto<MakeAppointmentForServiceResponse>
            {
                IsSuccess = false,
                Data = null,
                Message = $"An unexpected error occurred: {ex.Message}"
            };
        }
    }
}

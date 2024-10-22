using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.User;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly HttpClient _httpClient;

    public AppointmentRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
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
}
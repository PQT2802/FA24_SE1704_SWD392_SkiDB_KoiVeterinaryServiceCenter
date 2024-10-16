using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly HttpClient _httpClient;

    public AppointmentRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
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
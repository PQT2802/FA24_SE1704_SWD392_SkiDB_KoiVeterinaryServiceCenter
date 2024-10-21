using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.AppointmentForm;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentRepository;

    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }

    public async Task<ResponseDto<MakeAppointmentForServiceResponse>> MakeAppointmentAsync(MakeAppointmentForServiceRequest request)
    {
        var response = await _appointmentRepository.MakeAppointmentAsync(request);
        return response;
    }
}

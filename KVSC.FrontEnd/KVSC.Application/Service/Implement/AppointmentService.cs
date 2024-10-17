using KVSC.Infrastructure.DTOs;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentRepository;

    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }

    public async Task<ResponseDto<MakeAppointmentForServiceRequest>> MakeAppointmentForServiceAsync(MakeAppointmentForServiceRequest request)
    {
        // Here you can add additional business logic before calling the repository
        var result = await _appointmentRepository.MakeAppointmentForServiceAsync(request);

        // Add any additional business logic or transformations here

        return result;
    }
}
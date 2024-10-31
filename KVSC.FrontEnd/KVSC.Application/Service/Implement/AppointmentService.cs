using KVSC.Infrastructure.DTOs;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail;
using KVSC.Infrastructure.DTOs.Appointment.AddAppointment;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentRepository;

    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }

    public async Task<ResponseDto<GetAppointmentDetailResponse>> GetAppointmentDetail(Guid appointmentId)
    {
        var result = await _appointmentRepository.GetAppointmentDetail(appointmentId);

        return result;
    }

    public async Task<ResponseDto<AppointmentList>> GetAppoitmentListForVet(string token)
    {
        var result = await _appointmentRepository.GetAppoitmentListForVet(token);

        // Add any additional business logic or transformations here

        return result;
    }

    public async Task<ResponseDto<AppointmentList>> GetAppointmentListForCustomer(string token)
    {
        var result = await _appointmentRepository.GetAppointmentListForCustomer(token);
        return result;
    }



    public async Task<ResponseDto<MakeAppointmentForServiceRequest>> MakeAppointmentForServiceAsync(
        MakeAppointmentForServiceRequest request)
    {
        // Here you can add additional business logic before calling the repository
        var result = await _appointmentRepository.MakeAppointmentForServiceAsync(request);

        // Add any additional business logic or transformations here

        return result;
    }

    public async Task<ResponseDto<UpdateStatusResponse>> UpdateAppointmentStatusAsync(Guid appointmentId, string status)
    {
        var result = await _appointmentRepository.UpdateAppointmentStatusAsync(appointmentId, status);

        // Add any additional business logic or transformations here

        return result;
    }
    public async Task<ResponseDto<AppointmentList>> GetUnassignedAppointmentsAsync()
    {
        return await _appointmentRepository.GetUnassignedAppointmentsAsync();
    }
    public async Task<ResponseDto<VeterinarianDto>> GetAvailableVeterinarians(Guid appointmentId)
    {
        var response = await _appointmentRepository.GetAvailableVeterinariansAsync(appointmentId);
        return response;
    }
    public async Task<ResponseDto<AssignVeterinarianResponse>> AssignVeterinarianToAppointment(AssignVeterinarianRequest request)
    {
        return await _appointmentRepository.AssignVeterinarian(request);
    }

}
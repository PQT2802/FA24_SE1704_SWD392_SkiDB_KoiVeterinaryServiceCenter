using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.AppointmentForm;

public interface IAppointmentRepository
{
    Task<ResponseDto<MakeAppointmentForServiceResponse>> MakeAppointmentAsync(MakeAppointmentForServiceRequest request);

}
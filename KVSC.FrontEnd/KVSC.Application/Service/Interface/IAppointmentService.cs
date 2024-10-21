using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.AppointmentForm;

public interface IAppointmentService
{
    Task<ResponseDto<MakeAppointmentForServiceResponse>> MakeAppointmentAsync(MakeAppointmentForServiceRequest request);

}
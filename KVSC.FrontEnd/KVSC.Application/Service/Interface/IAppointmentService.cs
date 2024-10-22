using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail;
using System.Threading.Tasks;

public interface IAppointmentService
{
    Task<ResponseDto<MakeAppointmentForServiceRequest>> MakeAppointmentForServiceAsync(MakeAppointmentForServiceRequest request);
    //Task<ResponseDto<List<AppointmentList>>> GetAppointmentListAsync();
    Task<ResponseDto<AppointmentList>> GetAppoitmentListForVet(string token);
    Task<ResponseDto<UpdateStatusResponse>> UpdateAppointmentStatusAsync(Guid appointmentId, string status);
    //ez 
    Task<ResponseDto<GetAppointmentDetailResponse>> GetAppointmentDetail(Guid appointmentId);
}
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Appointment.AddAppointment;
using KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;
using System.Threading.Tasks;

public interface IAppointmentService
{
    Task<ResponseDto<MakeAppointmentForServiceRequest>> MakeAppointmentForServiceAsync(
        MakeAppointmentForServiceRequest request);

    //Task<ResponseDto<List<AppointmentList>>> GetAppointmentListAsync();
    Task<ResponseDto<AppointmentList>> GetAppoitmentListForVet(string token);
    Task<ResponseDto<AppointmentList>> GetAppointmentListForCustomer(string token);
    Task<ResponseDto<UpdateStatusResponse>> UpdateAppointmentStatusAsync(Guid appointmentId, string status);

    //ez 
    Task<ResponseDto<GetAppointmentDetailResponse>> GetAppointmentDetail(Guid appointmentId);
    Task<ResponseDto<AppointmentList>> GetUnassignedAppointmentsAsync();
    Task<ResponseDto<VeterinarianDto>> GetAvailableVeterinarians(Guid appointmentId);
    Task<ResponseDto<AssignVeterinarianResponse>> AssignVeterinarianToAppointment(AssignVeterinarianRequest request);
    Task<ResponseDto<MakeAppointmentResponse>> MakeAppointmentAsync(MakeAppointmentRequest request);
    Task<ResponseDto<CommonMessage>> AddServiceReport(AddServiceReportRequest request);
}
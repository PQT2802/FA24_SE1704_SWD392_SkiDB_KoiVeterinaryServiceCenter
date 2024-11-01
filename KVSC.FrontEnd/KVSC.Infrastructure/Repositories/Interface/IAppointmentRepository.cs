using KVSC.Infrastructure.DTOs;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Appointment;
using KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail;
using KVSC.Infrastructure.DTOs.Appointment.AddAppointment;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;

public interface IAppointmentRepository
{
    Task<ResponseDto<MakeAppointmentForServiceRequest>> MakeAppointmentForServiceAsync(
        MakeAppointmentForServiceRequest request);

    Task<ResponseDto<AppointmentList>> GetAppoitmentListForVet(string token);
    Task<ResponseDto<AppointmentList>> GetAppointmentListForCustomer(string token);
    Task<ResponseDto<UpdateStatusResponse>> UpdateAppointmentStatusAsync(Guid appointmentId, string status);
    Task<ResponseDto<GetAppointmentDetailResponse>> GetAppointmentDetail(Guid appointmentId);
    Task<ResponseDto<AppointmentList>> GetUnassignedAppointmentsAsync();
    Task<ResponseDto<VeterinarianDto>> GetAvailableVeterinariansAsync(Guid appointmentId);
    Task<ResponseDto<AssignVeterinarianResponse>> AssignVeterinarian(AssignVeterinarianRequest request);

    Task<ResponseDto<MakeAppointmentResponse>> MakeAppointmentAsync(MakeAppointmentRequest request);
    Task<ResponseDto<CommonMessage>> AddServiceReport(AddServiceReportRequest request);

}
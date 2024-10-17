using KVSC.Infrastructure.DTOs;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Appointment;

public interface IAppointmentRepository
{
    Task<ResponseDto<MakeAppointmentForServiceRequest>> MakeAppointmentForServiceAsync(MakeAppointmentForServiceRequest request);
    Task<ResponseDto<AppointmentList>> GetAppoitmentListForVet(string token);
}
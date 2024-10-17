using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Appointment;
using System.Threading.Tasks;

public interface IAppointmentService
{
    Task<ResponseDto<MakeAppointmentForServiceRequest>> MakeAppointmentForServiceAsync(MakeAppointmentForServiceRequest request);
    Task<ResponseDto<List<AppointmentList>>> GetAppointmentListAsync();
    //ez 
}
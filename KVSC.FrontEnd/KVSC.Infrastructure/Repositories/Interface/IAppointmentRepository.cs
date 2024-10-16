using KVSC.Infrastructure.DTOs;
using System.Threading.Tasks;

public interface IAppointmentRepository
{
    Task<ResponseDto<MakeAppointmentForServiceRequest>> MakeAppointmentForServiceAsync(MakeAppointmentForServiceRequest request);
}
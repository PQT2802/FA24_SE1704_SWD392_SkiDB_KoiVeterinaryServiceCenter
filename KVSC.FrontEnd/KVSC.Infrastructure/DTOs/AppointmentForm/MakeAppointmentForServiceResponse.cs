namespace KVSC.Infrastructure.DTOs.AppointmentForm
{
    public class MakeAppointmentForServiceResponse
    {
        public Extensions<MakeAppointmentForServiceResponseData> Extensions { get; set; }


    }
    public class MakeAppointmentForServiceResponseData
    {
        public Guid AppointmentId { get; set; }
    }

}

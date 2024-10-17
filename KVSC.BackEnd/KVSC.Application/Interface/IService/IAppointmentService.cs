using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Appointment.GetAppointment;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IAppointmentService
    {
        public Task<Result> MakeAppointmentForServiceAsync(MakeAppointmentForServiceRequest request);
        public Task<Result> MakeAppointmentForComboAsync(MakeAppointmentForComboRequest request);
        public Task<Result> GetAppointmentListByUserIdAsync(Guid userId);
        public Task<Result> GetAppointmentListAsync();
    }
}

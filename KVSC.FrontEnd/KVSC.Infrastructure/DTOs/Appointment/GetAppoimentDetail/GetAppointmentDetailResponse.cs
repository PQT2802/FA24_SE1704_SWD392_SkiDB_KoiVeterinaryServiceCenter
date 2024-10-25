using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail
{
    public class GetAppointmentDetailResponse
    {
        public Extensions<GetAppointmentDetailData> Extensions { get; set; }
    }
    public class GetAppointmentDetailData
    {
        public AppointmentDetailService AppointmentDetailService { get; set; }
        public AppointmentDetailCustomer AppointmentDetailCustomer { get; set; }
        public AppointmentDetailVeterinarian AppointmentDetailVeterinarian { get; set; }
        public AppointmentDetailKoi AppointmentDetailKoi { get; set; }
        public AppointmentDetailReport AppointmentDetailReport { get; set; }
    }
    
}

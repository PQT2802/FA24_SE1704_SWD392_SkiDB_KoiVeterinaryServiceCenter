using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment
{
    public class UpdateStatusResponse
    {

        public Extensions<UpdateStatusResponseData> Extensions { get; set; }
    }
    public class UpdateStatusResponseData
    {
        public Guid Id { get; set; }
    }
}

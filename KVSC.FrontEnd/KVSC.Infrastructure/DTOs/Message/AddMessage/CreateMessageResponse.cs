using KVSC.Infrastructure.DTOs.Service.AddService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Message.AddMessage
{
    public class CreateMessageResponse
    {
        public Extensions<AddServiceData> Extensions { get; set; }
    }
    public class CreateMessageData
    {
        public Guid Id { get; set; }
    }
}

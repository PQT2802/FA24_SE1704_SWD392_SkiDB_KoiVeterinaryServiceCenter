using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public class CommonMessage
    {
        public Extensions<CommonMessageData> Extensions { get; set; }
    }
    public class CommonMessageData
    {
        public string Message { get; set; }
    }
}

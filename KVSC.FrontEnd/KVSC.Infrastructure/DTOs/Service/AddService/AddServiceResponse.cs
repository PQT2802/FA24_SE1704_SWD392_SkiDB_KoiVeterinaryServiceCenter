using KVSC.Infrastructure.DTOs.User.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Service.AddService
{
    public class AddServiceResponse
    {
        public Extensions<AddServiceData> Extensions { get; set; }
    }
    public class AddServiceData
    {
        public Guid Id { get; set; }
    }
}

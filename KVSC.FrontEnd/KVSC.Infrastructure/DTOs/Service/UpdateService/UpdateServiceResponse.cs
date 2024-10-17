using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Service.UpdateService
{
    public class UpdateServiceResponse
    {
        public Extensions<UpdateServiceData> Extensions { get; set; }
    }
    public class UpdateServiceData
    {
        public Guid Id { get; set; }
    }
}

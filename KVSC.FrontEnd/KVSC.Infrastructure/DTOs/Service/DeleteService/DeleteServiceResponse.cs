using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Service.DeleteService
{
    public class DeleteServiceResponse
    {
        public Extensions<DeleteServiceData> Extensions { get; set; }
    }
    public class DeleteServiceData
    {
        public Guid Id { get; set; }
    }
}

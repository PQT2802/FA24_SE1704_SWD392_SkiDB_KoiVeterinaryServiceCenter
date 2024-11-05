using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.User
{
    public class GetVetInfo
    {
        public Extensions<List<VetData>> Extensions { get; set; }
    }
    public class VetData
    {
        public Guid UserId { get; set; }
        public string Qualifications { get; set; }
        public string Specialty { get; set; }
    }
}

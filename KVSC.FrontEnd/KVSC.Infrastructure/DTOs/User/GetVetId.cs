using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.User
{
    public class GetVetId
    {
        public Extensions<List<GetVetIdData>> Extensions { get; set; }
    }
    public class GetVetIdData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

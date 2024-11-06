using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Manager
{
    public class PetServiceTopRating
    {
        public Guid PetServiceId { get; set; }
        public string ServiceName { get; set; }
        public double AverageRating { get; set; }
    }
}

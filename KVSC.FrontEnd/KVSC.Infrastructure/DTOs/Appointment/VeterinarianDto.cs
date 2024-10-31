using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment
{
    public class VeterinarianDto
    {
        public Extensions<List<VeterinarianDtoData>> Extensions { get; set; }
        public class VeterinarianDtoData
        {
            public Guid Id { get; set; }
            public Guid VeterinarianId { get; set; }
            public string FullName { get; set; }
            public string Qualifications { get; set; }
            public TimeSpan StartTime { get; set; }
            public TimeSpan EndTime { get; set; }
            public string Specialty { get; set; }
        }
    }
}

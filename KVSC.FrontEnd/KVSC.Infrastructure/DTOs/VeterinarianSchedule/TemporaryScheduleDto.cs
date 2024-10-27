using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.VeterinarianSchedule
{
    public class TemporaryScheduleDto
    {
        public Extensions<Dictionary<string, List<TemporaryScheduleDtoData>>> Extensions { get; set; }
    }

    public class TemporaryScheduleDtoData
    {
        public Guid VeterinarianId { get; set; }
        public string VeterinarianName { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool IsAvailable { get; set; }
    }
}

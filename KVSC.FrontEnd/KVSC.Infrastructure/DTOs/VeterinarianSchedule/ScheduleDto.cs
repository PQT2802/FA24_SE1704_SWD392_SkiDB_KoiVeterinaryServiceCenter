using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.VeterinarianSchedule
{
    public class ScheduleDto
    {
        public Extensions<List<ScheduleDtoData>> Extensions { get; set; }
    }
    public class ScheduleDtoData
    {
        public string VeterinarianName { get; set; }
        public Guid VeterinarianId { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Shift { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
    }
}

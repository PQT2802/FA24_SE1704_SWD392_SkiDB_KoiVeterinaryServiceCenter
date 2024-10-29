using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Schedule
{
    public class ScheduleDto
    {
        public Guid VeterinarianId { get; set; }
        public string VeterinarianName { get; set; } // Added to include the veterinarian's name
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsAvailable { get; set; }
    }
}

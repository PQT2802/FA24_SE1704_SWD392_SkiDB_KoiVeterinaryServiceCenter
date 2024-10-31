using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.VeterinarianSchedule
{
    public class DeleteShiftRequest
    {
        public DateTime Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Shift { get; set; }
        public Guid Id { get; set; }
    }
}

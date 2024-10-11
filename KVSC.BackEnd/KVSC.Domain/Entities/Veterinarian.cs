using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class Veterinarian : BaseEntity
    {
        public Guid UserId { get; set; }  // Foreign key to the User entity

        public string LicenseNumber { get; set; } // Số giấy phép hành nghề
        public string Specialty { get; set; } // Chuyên môn
        public string Qualifications { get; set; } // Học vị/chứng chỉ

        // Navigation properties
        public virtual User User { get; set; } // Quan hệ với User, marked as virtual for lazy loading
        public virtual ICollection<AppointmentVeterinarian> AppointmentVeterinarians { get; set; } // Quan hệ với AppointmentVeterinarian
        public virtual ICollection<VeterinarianSchedule> VeterinarianSchedules { get; set; } // Quan hệ với VeterinarianSchedule
    }
}

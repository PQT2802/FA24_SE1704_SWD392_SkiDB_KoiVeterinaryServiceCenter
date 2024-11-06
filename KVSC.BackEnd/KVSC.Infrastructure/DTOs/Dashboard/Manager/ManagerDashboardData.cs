using KVSC.Infrastructure.DTOs.Dashboard.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Manager
{
    public class ManagerDashboardData
    {
        public int TotalCustomers { get; set; }
        public int TotalVeterinarians { get; set; }
        public int TotalStaffs { get; set; }
        public decimal TotalPayments { get; set; }

        public Dictionary<string, int> AppointmentStatusCounts { get; set; } 
        public List<PetServiceTopBooking> TopServicesByBookings { get; set; }
        public List<PetServiceTopRating> TopServicesByRating { get; set; }
        public List<PetServiceTopCancellation> TopServicesByCancellations { get; set; }
    }
}

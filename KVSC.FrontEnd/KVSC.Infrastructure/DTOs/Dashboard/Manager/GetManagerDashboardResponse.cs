using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Manager
{
    public class GetManagerDashboardResponse
    {
        public Extensions<GetManagerDashboardData> Extensions { get; set; }

    }
    public class GetManagerDashboardData
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

    public class PetServiceTopBooking
    {
        public string ServiceName { get; set; }
        public int BookingsCount { get; set; }
    }

    public class PetServiceTopRating
    {
        public string ServiceName { get; set; }
        public double AverageRating { get; set; }
    }

    public class PetServiceTopCancellation
    {
        public string ServiceName { get; set; }
        public int CancellationsCount { get; set; }
    }
}

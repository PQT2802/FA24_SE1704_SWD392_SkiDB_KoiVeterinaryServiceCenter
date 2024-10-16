using System;
using System.Collections.Generic;
using KVSC.Infrastructure.DTOs.Service;

namespace KVSC.Infrastructure.DTOs
{
    public class AppointmentFormViewModel
    {
        public Guid CustomerId { get; set; }
        public Guid PetServiceId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public List<Data> Services { get; set; } = new List<Data>(); // List of services available for selection
    }
}
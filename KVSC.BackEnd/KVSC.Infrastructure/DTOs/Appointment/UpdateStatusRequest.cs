﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment
{
    public class UpdateStatusRequest
    {
        public Guid AppointmentId { get; set; }
        public string Status { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Appointment.GetAppoimentDetail
{
    public class AppointmentDetailVet : AppointmentDetailCustomer
    {
        public string Specialty { get; set; }
        public string LicenseNumber { get; set; }
    }
}

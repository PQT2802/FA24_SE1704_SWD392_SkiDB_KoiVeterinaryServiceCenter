﻿using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Appointment
{
    public class MakeAppointmentForServiceValidator : AppointmentForServiceValidator<MakeAppointmentForServiceRequest>
    {
        public MakeAppointmentForServiceValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            MakeAppointmentForServiceRules(request => request.CustomerId, "Customer");
            MakeAppointmentForServiceRules(request => request.CustomerId, "Pet");
        }
    }
}

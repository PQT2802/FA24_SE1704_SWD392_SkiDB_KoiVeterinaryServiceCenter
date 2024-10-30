﻿using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Appointment.GetAppointment;
using KVSC.Infrastructure.DTOs.Appointment.GetAppointmentDetail;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IAppointmentRepository : IGenericRepository<Appointment>
    {
        public Task<Appointment> CreateAppointmentAsync(Appointment appointment);

        // READ (các phương thức khác nếu cần)
        public Task<IEnumerable<Appointment>> GetAllAppointmentsAsync();
        public Task<IEnumerable<GetAllAppointment>> GetAppointmentListAsync();
        public Task<IEnumerable<GetAllAppointment>> GetAppointmentListByUserIdAsync(Guid userId);
        public Task<Veterinarian> GetAvailableVeterinarianAsync(DateTime appointmentDate);
        public Task UpdateScheduleAvailabilityAsync(Guid veterinarianId, DateTime appointmentDate);
        public Task<bool> AppointmentExistsAsync(Guid appointmentId);
        public Task<Guid> UpdateAppointmentStatusAsync(Guid appointmentId, string status);

        public Task<GetAppointmentDetail> GetAppointmentDetailAsync(Guid appointmentId);
        public Task<Appointment> GetAppointmentByIdAsync(Guid appointmentId);
        public Task<int> AssignVeterinarianToAppointment(Guid appointmentId, Guid veterinarianId);


    }
}

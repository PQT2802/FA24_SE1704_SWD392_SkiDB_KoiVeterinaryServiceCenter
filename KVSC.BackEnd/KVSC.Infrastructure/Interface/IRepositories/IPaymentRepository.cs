using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
        Task<Payment> AddPaymentAsync(Payment payment);
        Task<Payment> GetPaymentByAppointmentIdAsync(Guid appointmentId);
        Task<List<GetPayment>> GetPaymentByUserIdAsync(Guid userId);
        Task<bool> UpdatePayment(Guid userId);
    }
}

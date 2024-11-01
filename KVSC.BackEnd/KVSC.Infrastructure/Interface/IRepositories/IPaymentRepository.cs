using KVSC.Domain.Entities;
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
        Task<Payment> GetPaymentByUserIdAsync(Guid userId);
        Task<bool> UpdatePayment(Guid userId);
    }
}

using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(KVSCContext context) : base(context)
        {
            
        }
        public async Task<Payment> AddPaymentAsync(Payment payment)
        {
            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
            return payment;
        }
        public async Task<Payment> GetPaymentByAppointmentIdAsync(Guid appointmentId)
        {
            return await _context.Payments.FirstOrDefaultAsync(p => p.AppointmentId == appointmentId);
        }
        public async Task<Payment> GetPaymentByUserIdAsync(Guid userId)
        {
            // Assuming _context is your DbContext instance
            return await _context.Payments
                .Include(p => p.Appointment) // Include Appointment to access CustomerId
                .Where(p => p.Appointment.CustomerId == userId)
                .FirstOrDefaultAsync();
        }
        public async Task<bool> UpdatePayment(Guid userId)
        {
            // Find the payment based on the userId by joining with Appointment
            var payment = await _context.Payments
                .Include(p => p.Appointment) // Include Appointment to access CustomerId
                .FirstOrDefaultAsync(p => p.Appointment.CustomerId == userId);

            // Check if the payment exists
            if (payment == null)
            {
                return false; // Payment not found for the given userId
            }

            // Update the totalAmountStatus to true
            payment.totalAmountStatus = true;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return true;
        }

    }
}

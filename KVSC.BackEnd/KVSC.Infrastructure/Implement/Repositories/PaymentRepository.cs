using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.DTOs.Payment;
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
        public async Task<List<GetPayment>> GetPaymentByUserIdAsync(Guid userId)
        {
            return await _context.Payments
                .Include(p => p.Appointment)
                .ThenInclude(s => s.PetService)// Bao gồm Appointment để truy cập CustomerId
                .Where(p => p.Appointment.CustomerId == userId)
                .Select(p => new GetPayment
                {
                    PaymentId = p.Id,
                    CustomerId = userId,
                    AppointmentId = p.AppointmentId,
                    ServiceName = p.Appointment.PetService.Name,
                    BasePrice = p.Appointment.PetService.BasePrice,
                    TravelCost = p.Appointment.PetService.TravelCost,
                    TotalAmount = p.TotalAmount,
                    Deposit = p.Deposit,
                    Status = p.Status,
                    TotalAmountStatus = p.TotalAmountStatus,
                    DepositStatus = p.DepositStatus
                })
                .ToListAsync(); // Lấy toàn bộ kết quả dưới dạng danh sách
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

            // Update the TotalAmountStatus to true
            payment.TotalAmountStatus = true;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return true;
        }

    }
}

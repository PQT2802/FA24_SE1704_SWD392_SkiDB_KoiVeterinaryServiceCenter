using Azure.Core;
using FluentValidation;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Appointment.GetAppointment;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<MakeAppointmentForServiceRequest> _serviceValidator;
        private readonly IValidator<MakeAppointmentForComboRequest> _comboValidator;

        public AppointmentService(IUnitOfWork unitOfWork,
                             IValidator<MakeAppointmentForServiceRequest> serviceValidator,
                             IValidator<MakeAppointmentForComboRequest> comboValidator)
        {
            _unitOfWork = unitOfWork;
            _serviceValidator = serviceValidator;
            _comboValidator = comboValidator;
        }

        public async Task<Result> MakeAppointmentForServiceAsync(MakeAppointmentForServiceRequest request)
        {
            // Validate the input
            var validationResult = await _serviceValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            var pet = await _unitOfWork.PetRepository.GetByIdAsync(request.PetId);
            if (pet == null)
            {
                return Result.Failure(PetErrorMessage.FieldIsEmpty("pet"));
            }

            var appointment = new Appointment
            {
                CustomerId = request.CustomerId,
                PetId = request.PetId,
                PetServiceId = request.PetServiceId,
                Status = "Pending",
                AppointmentDate = request.AppointmentDate,
            };
            // Nếu không có bác sĩ nào được chọn, tự động lấy bác sĩ dựa trên lịch trống
            if (request.VeterinarianIds == null || !request.VeterinarianIds.Any())
            {
                var availableVeterinarian = await _unitOfWork.AppointmentRepository.GetAvailableVeterinarianAsync(appointment.AppointmentDate);
                if (availableVeterinarian != null)
                {
                    // Chỉ gán một bác sĩ thú y cho cuộc hẹn
                    appointment.AppointmentVeterinarians = new List<AppointmentVeterinarian>
                    {
                        new AppointmentVeterinarian { VeterinarianId = availableVeterinarian.Id }
                    };
                }
            }
            else
            {
                // Nếu có bác sĩ được chọn, thêm vào cuộc hẹn
                appointment.AppointmentVeterinarians = request.VeterinarianIds.Select(v => new AppointmentVeterinarian
                {
                    VeterinarianId = v
                }).ToList();
            }
            // Lưu cuộc hẹn
            await _unitOfWork.AppointmentRepository.CreateAppointmentAsync(appointment);

            // Cập nhật trạng thái IsAvailable của lịch bác sĩ qua repository
            foreach (var veterinarian in appointment.AppointmentVeterinarians)
            {
                await _unitOfWork.AppointmentRepository.UpdateScheduleAvailabilityAsync(
                    veterinarian.VeterinarianId,
                    appointment.AppointmentDate
                );
            }

            var response = new CreateResponse { Id = appointment.Id };
            return Result.SuccessWithObject(response);
        }

        public async Task<Result> MakeAppointmentForComboAsync(MakeAppointmentForComboRequest request)
        {
            // Validate the input
            var validationResult = await _comboValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            //var pet = await _unitOfWork.PetRepository.GetByIdAsync(request.PetId);
            //if (pet == null)
            //{
            //    return Result.Failure("Pet not found.");
            //}

            var appointment = new Appointment
            {
                CustomerId = request.CustomerId,
                PetId = request.PetId,
                ComboServiceId = request.ComboServiceId,
                AppointmentDate = DateTime.UtcNow, // Hoặc thời gian mà người dùng chọn
                Status = "Pending"
            };

            await _unitOfWork.AppointmentRepository.CreateAppointmentAsync(appointment);
            var response = new CreateResponse { Id = appointment.Id };
            return Result.SuccessWithObject(response);
        }
        public async Task<Result> GetAllAppointmentsAsync()
        {
            var availableVeterinarian = await _unitOfWork.AppointmentRepository.GetAllAppointmentsAsync();
            return null;
        }

        public async Task<Result> GetAppointmentListAsync()
        {
            var appointments = await _unitOfWork.AppointmentRepository.GetAppointmentListAsync();
            return Result.SuccessWithObject(appointments);
        }

        public async Task<Result> GetAppointmentListByUserIdAsync(Guid userId)
        {
            var appointments = await _unitOfWork.AppointmentRepository.GetAppointmentListByUserIdAsync(userId);

            if (appointments == null || !appointments.Any())
            {
                var error = Error.NotFound("AppointmentNotFound", "No appointments found for the specified veterinarian.");
                return Result.Failure(error);
            }

            return Result.SuccessWithObject(appointments);
        }
        
        public async Task<Result> GetAppointmentListByCustomerIdAsync(Guid userId)
        {
            var appointments = await _unitOfWork.AppointmentRepository.GetAppointmentListByCustomerIdAsync(userId);

            if (appointments == null || !appointments.Any())
            {
                var error = Error.NotFound("AppointmentNotFound", "No appointments found for the specified customer.");
                return Result.Failure(error);
            }

            return Result.SuccessWithObject(appointments);
        }


        public async Task<Result> UpdateAppointmentStatusAsync(Guid appointmentId, string status)
        {
            //var appoint = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
            //if (appoint == null)
            //{
            //    var error = Error.NotFound("AppointmentNotFound", "No appointments found for the specified veterinarian.");
            //    return Result.Failure(error);
            //}

            //if (appoint.AppointmentDate > DateTime.Now)
            //{
            //    var error = Error.Validation("AppointmentTooEarly", "The appointment time has not yet arrived for execution.");
            //    return Result.Failure(error);
            //}

            var result = await _unitOfWork.AppointmentRepository.UpdateAppointmentStatusAsync(appointmentId, status);
            if (result == Guid.Empty)
            {
                var error = Error.NotFound("AppointmentNotFound", "No appointments found for the specified veterinarian.");
                return Result.Failure(error);
            }

            return Result.SuccessWithObject(new { id = result });
        }
        public async Task<Result> GetAppointmentDetailByIdAsync(Guid appointmentId)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetAppointmentDetailAsync(appointmentId);
            if (appointment == null)
            {
                return Result.Failure(Error.NotFound("AppointmentNotFound", "Appointment not found."));
            }
            return Result.SuccessWithObject(appointment);
        }


        public async Task<Result> MakeAppointmentForServiceAsyncNotAuto(MakeAppointmentForServiceRequest request)
        {
            var pet = await _unitOfWork.PetRepository.GetByIdAsync(request.PetId);
            if (pet == null)
            {
                return Result.Failure(PetErrorMessage.FieldIsEmpty("pet"));
            }
            var wallet = await _unitOfWork.WalletRepository.GetWalletByUserIdAsync(request.CustomerId);
            if(wallet == null)
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }
            var service = await _unitOfWork.PetServiceRepository.GetByIdAsync(request.PetServiceId);
            if(service == null)
            {
                return Result.Failure(PetServiceErrorMessage.PetServiceNotFound());
            }
            if(wallet.Amount < (service.BasePrice * 0.2m))
            {
                return Result.Failure(Error.Validation("InsufficientFunds", "Insufficient funds in wallet."));
            }
            var appointment = new Appointment
            {
                CustomerId = request.CustomerId,
                PetId = request.PetId,
                PetServiceId = request.PetServiceId,
                Status = "Pending",
                AppointmentDate = request.AppointmentDate,
            };
                // Nếu có bác sĩ được chọn, thêm vào cuộc hẹn
                appointment.AppointmentVeterinarians = request.VeterinarianIds.Select(v => new AppointmentVeterinarian
                {
                    VeterinarianId = v
                }).ToList();
            
            // Lưu cuộc hẹn 
            await _unitOfWork.AppointmentRepository.CreateAppointmentAsync(appointment);
            wallet.Amount = wallet.Amount - (service.BasePrice * 0.2m);
            await _unitOfWork.WalletRepository.UpdateAsync(wallet);

            // Cập nhật trạng thái IsAvailable của lịch bác sĩ qua repository
            foreach (var veterinarian in appointment.AppointmentVeterinarians)
            {
                await _unitOfWork.AppointmentRepository.UpdateScheduleAvailabilityAsync(
                    veterinarian.VeterinarianId,
                    appointment.AppointmentDate
                );
            }
                var response = new CreateResponse { Id = appointment.Id };
                return Result.SuccessWithObject(response);
        }

        public async Task<Result> GetUnassignedAppointmentsAsync()
        {
            var unassignedAppointments = await _unitOfWork.AppointmentRepository
                .GetAllAppointmentsAsync(); // Adjust this line based on your data access implementation.
            if (unassignedAppointments == null)
            {
                return Result.Failure(Error.NotFound("AppointmentsNotFound", "No appointments found."));
            }
            // Lọc ra các cuộc hẹn chưa có bác sĩ chỉ định
            var filteredAppointments = unassignedAppointments
                .Where(a => a.AppointmentVeterinarians == null || !a.AppointmentVeterinarians.Any())
                .Select(a => new GetAllAppointment
                {
                    AppointmentListId = a.Id,  // Sử dụng Id từ đối tượng Appointment
                    CustomerId = a.CustomerId,
                    PetServiceId = a.PetServiceId ?? Guid.Empty,
                    VeterinarianId = Guid.Empty, 
                    CustomerName = a.Customer?.FullName ?? string.Empty, 
                    VeterinarianName = string.Empty, 
                    ServiceName = a.PetService?.Name ?? string.Empty, 
                    Status = a.Status,
                    AppointmentDate = a.AppointmentDate
                }).ToList();

            return Result.SuccessWithObject(filteredAppointments);
        }
        public async Task<Result> GetAppointmentByIdAsync(Guid appointmentId)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetAppointmentByIdAsync(appointmentId); // Or similar method in the repository

            if (appointment == null)
            {
                return Result.Failure(Error.NotFound("AppointmentNotFound", "Appointment not found."));
            }
            var appointmentDto = new GetAllAppointment
            {
                AppointmentListId = appointment.Id,
                CustomerId = appointment.CustomerId,
                PetServiceId = appointment.PetServiceId ?? Guid.Empty, // Sử dụng Guid.Empty nếu không có
                VeterinarianId = appointment.AppointmentVeterinarians?.FirstOrDefault()?.VeterinarianId ?? Guid.Empty,
                CustomerName = appointment.Customer?.FullName ?? string.Empty, // Giả sử Customer có thuộc tính Name
                VeterinarianName = string.Empty, // Tên bác sĩ thú y đầu tiên
                ServiceName = appointment.PetService?.Name ?? string.Empty, // Giả sử PetService có thuộc tính Name
                Status = appointment.Status,
                AppointmentDate = appointment.AppointmentDate
            };

            return Result.SuccessWithObject(appointmentDto);
        }

        public async Task<Result> AssignVeterinarianAsync(Guid appointmentId, Guid veterinarianId)
        {
            try
            {
                var result = await _unitOfWork.AppointmentRepository.AssignVeterinarianToAppointment(appointmentId, veterinarianId);
                if(result > 0)
                {
                    return Result.SuccessWithObject(appointmentId);
                }
                return Result.Failure(Error.NotFound("AppointmentNotFound", "Appointment not found."));
            }
            catch (InvalidOperationException ex)
            {
                return Result.Failure(Error.NotFound("AssignmentError", ex.Message));
            }
        }



    }
}

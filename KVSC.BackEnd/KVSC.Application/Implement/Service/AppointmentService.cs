using FluentValidation;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;

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

        public async Task<Result> MakeAppointmentAsync(MakeAppointmentForServiceRequest request)
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

            // Step 1: Check if a veterinarian was selected by the user
            if (request.VeterinarianIds != null && request.VeterinarianIds.Any())
            {
                // Step 2: Ensure selected veterinarians have no conflicting schedule
                var selectedVetId = request.VeterinarianIds.First(); // Assuming the user can only select one vet
                bool isVetAvailable = await _unitOfWork.AppointmentRepository.IsVeterinarianAvailableAsync(selectedVetId, appointment.AppointmentDate);

                if (!isVetAvailable)
                {
                    return Result.Failure(Error.Failure("PetNotFound", "The specified pet was not found."));
                }

                // Assign the selected veterinarian
                appointment.AppointmentVeterinarians = new List<AppointmentVeterinarian>
        {
            new AppointmentVeterinarian { VeterinarianId = selectedVetId }
        };
            }
            else
            {
                // Step 3: If no veterinarian is selected, assign a random available vet
                var availableVeterinarian = await _unitOfWork.AppointmentRepository.GetAvailableVeterinarianAsync(appointment.AppointmentDate);
                if (availableVeterinarian == null)
                {
                    return Result.Failure(Error.Failure("VetNotFound", "The specified Vet was not found."));
                }

                // Assign the random available veterinarian
                appointment.AppointmentVeterinarians = new List<AppointmentVeterinarian>
        {
            new AppointmentVeterinarian { VeterinarianId = availableVeterinarian.Id }
        };
            }

            // Step 4: Save the appointment
            await _unitOfWork.AppointmentRepository.CreateAppointmentAsync(appointment);

            // Step 5: Update veterinarian schedule availability
            foreach (var veterinarian in appointment.AppointmentVeterinarians)
            {
                await _unitOfWork.AppointmentRepository.UpdateScheduleAvailabilityAsync(veterinarian.VeterinarianId, appointment.AppointmentDate);
            }

            // Return success result with the appointment ID
            var response = new CreateResponse { Id = appointment.Id };
            return Result.SuccessWithObject(response);
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
    }
}

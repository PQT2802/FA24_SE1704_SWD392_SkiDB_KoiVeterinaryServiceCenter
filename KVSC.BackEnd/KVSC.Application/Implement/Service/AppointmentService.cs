using Azure.Core;
using FluentValidation;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Appointment.GetAppointment;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.EmailTemplate;
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
        private readonly IEmailTemplateService _emailTemplateService;

        public AppointmentService(IUnitOfWork unitOfWork,
                             IValidator<MakeAppointmentForServiceRequest> serviceValidator,
                             IValidator<MakeAppointmentForComboRequest> comboValidator,
                             IEmailTemplateService emailTemplateService)
        {
            _unitOfWork = unitOfWork;
            _serviceValidator = serviceValidator;
            _comboValidator = comboValidator;
            _emailTemplateService = emailTemplateService;
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
            // Update appointment status in the database
            var result = await _unitOfWork.AppointmentRepository.UpdateAppointmentStatusAsync(appointmentId, status);
            if (result == Guid.Empty)
            {
                var error = Error.NotFound("AppointmentNotFound", "No appointments found for the specified veterinarian.");
                return Result.Failure(error);
            }

            // Retrieve appointment details, customer, and veterinarian information as needed
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
            var customer = await _unitOfWork.UserRepository.GetByIdAsync(appointment.CustomerId);
            var veterinarian = (appointment.AppointmentVeterinarians?.FirstOrDefault() != null)
                               ? await _unitOfWork.VeterinarianScheduleRepository.GetVeterinarianByUserIdAsync(appointment.AppointmentVeterinarians.First().VeterinarianId)
                               : null;

            string appointmentDetailUrl = $"https://localhost:7283/api/appointment/detail/{appointmentId}";
            var placeholders = new Dictionary<string, string>
    {
        { "AppointmentDate", appointment.AppointmentDate.ToString("MMMM dd, yyyy") },
        { "AppointmentTime", appointment.AppointmentDate.ToString("hh:mm tt") },
        { "ServiceName", "Koi Care Service" }, // Replace with actual service name if available
        { "PetName", appointment.Pet.Name }, // Replace with actual pet name if available
        { "AppointmentDetailURL", appointmentDetailUrl }
    };

            // Send emails based on status
            switch (status)
            {
                case "Waiting":
                    if (veterinarian != null && !string.IsNullOrEmpty(veterinarian.User.Email))
                    {
                        placeholders["Name"] = veterinarian.User.FullName;
                        var emailBodyResult = await _emailTemplateService.GenerateEmailForAppointmentStatusAsync(
                            "MakeAppointment", status, appointmentDetailUrl, placeholders);

                        if (emailBodyResult.IsSuccess)
                        {
                            var mailObject = new MailObject
                            {
                                ToMailIds = new List<string> { veterinarian.User.Email },
                                Subject = "New Appointment Assigned",
                                Body = emailBodyResult.Object as string,
                                IsBodyHtml = true
                            };
                            await _emailTemplateService.SendMail(mailObject);
                        }
                    }
                    break;

                case "InProgress":
                    // Notify both veterinarian and customer
                    if (veterinarian != null && !string.IsNullOrEmpty(veterinarian.User.Email))
                    {
                        placeholders["Name"] = veterinarian.User.FullName;
                        var vetEmailBodyResult = await _emailTemplateService.GenerateEmailForAppointmentStatusAsync(
                            "InProgressNotification", status, appointmentDetailUrl, placeholders);

                        if (vetEmailBodyResult.IsSuccess)
                        {
                            var vetMailObject = new MailObject
                            {
                                ToMailIds = new List<string> { veterinarian.User.Email },
                                Subject = "Appointment In Progress",
                                Body = vetEmailBodyResult.Object as string,
                                IsBodyHtml = true
                            };
                            await _emailTemplateService.SendMail(vetMailObject);
                        }
                    }

                    if (customer != null && !string.IsNullOrEmpty(customer.Email))
                    {
                        placeholders["Name"] = customer.FullName;
                        var custEmailBodyResult = await _emailTemplateService.GenerateEmailForAppointmentStatusAsync(
                            "InProgressNotification", status, appointmentDetailUrl, placeholders);

                        if (custEmailBodyResult.IsSuccess)
                        {
                            var custMailObject = new MailObject
                            {
                                ToMailIds = new List<string> { customer.Email },
                                Subject = "Your Appointment is In Progress",
                                Body = custEmailBodyResult.Object as string,
                                IsBodyHtml = true
                            };
                            await _emailTemplateService.SendMail(custMailObject);
                        }
                    }
                    break;

                case "Reported":
                    if (customer != null && !string.IsNullOrEmpty(customer.Email))
                    {
                        placeholders["Name"] = customer.FullName;
                        var reportEmailBodyResult = await _emailTemplateService.GenerateEmailForAppointmentStatusAsync(
                            "ReportNotification", status, appointmentDetailUrl, placeholders);

                        if (reportEmailBodyResult.IsSuccess)
                        {
                            var reportMailObject = new MailObject
                            {
                                ToMailIds = new List<string> { customer.Email },
                                Subject = "Your Appointment Report is Ready",
                                Body = reportEmailBodyResult.Object as string,
                                IsBodyHtml = true
                            };
                            await _emailTemplateService.SendMail(reportMailObject);
                        }
                    }
                    break;

                    // Add additional cases as needed for other statuses
            }

            return Result.SuccessWithObject(new { id = appointmentId });
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

            var appointment = new Appointment
            {
                CustomerId = request.CustomerId,
                PetId = request.PetId,
                PetServiceId = request.PetServiceId,
                Status = "Pending",
                AppointmentDate = request.AppointmentDate,
            };
            // Nếu có bác sĩ được chọn, thêm vào cuộc hẹn
            if (request.VeterinarianIds != null && request.VeterinarianIds.Any())
            {
                appointment.AppointmentVeterinarians = request.VeterinarianIds.Select(v => new AppointmentVeterinarian
                {
                    VeterinarianId = v
                }).ToList();
            }

            // Lưu cuộc hẹn 
            await _unitOfWork.AppointmentRepository.CreateAppointmentAsync(appointment);

            // Cập nhật trạng thái IsAvailable của lịch bác sĩ qua repository
            if (appointment.AppointmentVeterinarians != null)
            {
                foreach (var veterinarian in appointment.AppointmentVeterinarians)
                {
                    await _unitOfWork.AppointmentRepository.UpdateScheduleAvailabilityAsync(
                        veterinarian.VeterinarianId,
                        appointment.AppointmentDate
                    );
                }
            }
            string appointmentDetailUrl = $"https://localhost:7283/api/appointment/detail/{appointment.Id}";
            var placeholders = new Dictionary<string, string>
            {
                { "AppointmentDate", appointment.AppointmentDate.ToString("MMMM dd, yyyy") },
                { "AppointmentTime", appointment.AppointmentDate.ToString("hh:mm tt") },
                { "ServiceName", "Koi Care Service" },  // Replace with actual service name if available
                { "PetName", pet?.Name ?? "Your Pet" },  // Replace with actual pet name if available
                { "AppointmentDetailURL", appointmentDetailUrl }
            };
            // Send email notifications to veterinarians, if any
            if (appointment.AppointmentVeterinarians != null)
            {
                foreach (var veterinarian in appointment.AppointmentVeterinarians)
                {
                    var vet = await _unitOfWork.VeterinarianScheduleRepository.GetVeterinarianByUserIdAsync(veterinarian.VeterinarianId);
                    if (vet != null && !string.IsNullOrEmpty(vet.User.FullName))
                    {
                        placeholders["Name"] = vet.User.FullName;
                        var emailBodyResult = await _emailTemplateService.GenerateEmailWithAppointmentLink(
                            "MakeAppointment", appointmentDetailUrl, placeholders
                        );

                        if (emailBodyResult.IsSuccess)
                        {
                            var mailObject = new MailObject
                            {
                                ToMailIds = new List<string> { vet.User.FullName },
                                Subject = "New Appointment Assignment",
                                Body = emailBodyResult.Object as string,
                                IsBodyHtml = true
                            };
                            await _emailTemplateService.SendMail(mailObject);
                        }
                    }
                }
            }

            // Send email notification to the customer, if found
            var customer = await _unitOfWork.UserRepository.GetByIdAsync(request.CustomerId);
            if (customer != null && !string.IsNullOrEmpty(customer.Email))
            {
                placeholders["Name"] = customer.FullName;
                var emailBodyResult = await _emailTemplateService.GenerateEmailWithAppointmentLink(
                    "MakeAppointment", appointmentDetailUrl, placeholders
                );

                if (emailBodyResult.IsSuccess)
                {
                    var mailObject = new MailObject
                    {
                        ToMailIds = new List<string> { customer.Email },
                        Subject = "Appointment Confirmation",
                        Body = emailBodyResult.Object as string,
                        IsBodyHtml = true
                    };
                    await _emailTemplateService.SendMail(mailObject);
                }
            }
            else
            {
                // Log or handle the case where the customer is not found or has no email
                // Optional: Return an error or warning if the customer is a required recipient
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
                // Assign the veterinarian to the appointment
                var result = await _unitOfWork.AppointmentRepository.AssignVeterinarianToAppointment(appointmentId, veterinarianId);
                if (result <= 0)
                {
                    return Result.Failure(Error.NotFound("AppointmentNotFound", "Appointment not found."));
                }

                // Retrieve the appointment details
                var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(appointmentId);
                if (appointment == null)
                {
                    return Result.Failure(Error.NotFound("AppointmentNotFound", "Appointment details not found."));
                }

                // Retrieve the pet information
                var pet = await _unitOfWork.PetRepository.GetByIdAsync((Guid)appointment.PetId);

                // Prepare the placeholders
                string appointmentDetailUrl = $"https://localhost:7283/api/appointment/detail/{appointmentId}";
                var placeholders = new Dictionary<string, string>
        {
            { "AppointmentDate", appointment.AppointmentDate.ToString("MMMM dd, yyyy") },
            { "AppointmentTime", appointment.AppointmentDate.ToString("hh:mm tt") },
            { "ServiceName", "Koi Care Service" },  // Replace with actual service name if available
            { "PetName", pet?.Name ?? "Your Pet" },
            { "AppointmentDetailURL", appointmentDetailUrl }
        };

                // Send email notification to the veterinarian
                var vet = await _unitOfWork.VeterinarianScheduleRepository.GetVeterinarianByUserIdAsync(veterinarianId);
                if (vet != null && !string.IsNullOrEmpty(vet.User.Email))
                {
                    placeholders["Name"] = vet.User.FullName;
                    var emailBodyResult = await _emailTemplateService.GenerateEmailWithAppointmentLink(
                        "MakeAppointment", appointmentDetailUrl, placeholders
                    );

                    if (emailBodyResult.IsSuccess)
                    {
                        var mailObject = new MailObject
                        {
                            ToMailIds = new List<string> { vet.User.Email },
                            Subject = "New Appointment Assignment",
                            Body = emailBodyResult.Object as string,
                            IsBodyHtml = true
                        };
                        await _emailTemplateService.SendMail(mailObject);
                    }
                }

                // Send email notification to the customer
                var customer = await _unitOfWork.UserRepository.GetByIdAsync(appointment.CustomerId);
                if (customer != null && !string.IsNullOrEmpty(customer.Email))
                {
                    placeholders["Name"] = customer.FullName;
                    var emailBodyResult = await _emailTemplateService.GenerateEmailWithAppointmentLink(
                        "MakeAppointment", appointmentDetailUrl, placeholders
                    );

                    if (emailBodyResult.IsSuccess)
                    {
                        var mailObject = new MailObject
                        {
                            ToMailIds = new List<string> { customer.Email },
                            Subject = "Appointment Confirmation",
                            Body = emailBodyResult.Object as string,
                            IsBodyHtml = true
                        };
                        await _emailTemplateService.SendMail(mailObject);
                    }
                }
                else
                {
                    // Optional: Handle the case where the customer is not found or has no email
                }

                return Result.SuccessWithObject(appointmentId);
            }
            catch (InvalidOperationException ex)
            {
                return Result.Failure(Error.NotFound("AssignmentError", ex.Message));
            }
        }




    }
}

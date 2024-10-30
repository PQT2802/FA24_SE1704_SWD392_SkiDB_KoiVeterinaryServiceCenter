using Cursus_Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KVSC.Infrastructure.DB.Configuration;

public class EmailTemplateConfiguration : IEntityTypeConfiguration<EmailTemplate>
{
    public void Configure(EntityTypeBuilder<EmailTemplate> builder)
    {
        builder.HasData(
             new EmailTemplate
             {
                 EmailTemplateId = new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                 Subject = "New Appointment Notification",
                 Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>You have a new appointment notification for your koi fish:</p>
                    <p>{{AppointmentDetails}}</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                 Type = "AppointmentNotification",
                 IsDelete = false,
                 CreateDate = DateTime.Now,
                 CreateBy = "System",
                 UpdateDate = DateTime.Now,
                 UpdateBy = "System"
             },
            new EmailTemplate
            {
                EmailTemplateId = new Guid("b4a72a2f-77b9-4fa7-8a87-bb1ef61f2446"),
                Subject = "Password Reset Request",
                Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>We received a request to reset your password. Click the link below to reset your password:</p>
                    <p><a href='{{ResetLink}}'>Reset Password</a></p>
                    <p>If you did not request a password reset, please ignore this email.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                Type = "ForgetPassword",
                IsDelete = false,
                CreateDate = DateTime.Now,
                CreateBy = "System",
                UpdateDate = DateTime.Now,
                UpdateBy = "System"
            },
            new EmailTemplate
            {
                EmailTemplateId = new Guid("fe241b67-9fb5-49d4-94ec-7801a8e71e9a"),
                Subject = "Your Password Has Been Reset",
                Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>Your password has been successfully reset. You can now log in with your new password.</p>
                    <p>If you did not request this change, please contact our support team immediately.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                Type = "ResetPassword",
                IsDelete = false,
                CreateDate = DateTime.Now,
                CreateBy = "System",
                UpdateDate = DateTime.Now,
                UpdateBy = "System"
            },
            new EmailTemplate
            {
                EmailTemplateId = new Guid("e42c3d1a-2e1c-4b2a-92f2-33d1cf2fdc2b"),
                Subject = "Account Confirmation",
                Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>Thank you for registering with the Koi Veterinary Service Center. Please confirm your account by clicking the link below:</p>
                    <p><a href='{{ConfirmationLink}}'>Confirm Account</a></p>
                    <p>If you did not register, please ignore this email.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                Type = "ConfirmationAccount",
                IsDelete = false,
                CreateDate = DateTime.Now,
                CreateBy = "System",
                UpdateDate = DateTime.Now,
                UpdateBy = "System"
            },
            new EmailTemplate
            {
                EmailTemplateId = new Guid("c2f45678-1a3d-4012-b4c1-234d5d7f8cde"),
                Subject = "Appointment Rejection Notification",
                Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>We regret to inform you that your appointment for koi services has been rejected for the following reason:</p>
                    <p>{{RejectionReason}}</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                Type = "RejectAppointment",
                IsDelete = false,
                CreateDate = DateTime.Now,
                CreateBy = "System",
                UpdateDate = DateTime.Now,
                UpdateBy = "System"
            },
            new EmailTemplate
            {
                EmailTemplateId = new Guid("94e2d05c-fbf9-4f1f-bf89-d2298f8b6b4b"),
                Subject = "Appointment Approval Notification",
                Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>We are pleased to inform you that your appointment for koi fish care has been approved.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                Type = "ApproveAppointment",
                IsDelete = false,
                CreateDate = DateTime.Now,
                CreateBy = "System",
                UpdateDate = DateTime.Now,
                UpdateBy = "System"
            },
            new EmailTemplate
            {
                EmailTemplateId = new Guid("ef3455b2-3a6e-4cb5-9c6d-a432d9f1c7ab"),
                Subject = "Account Activation",
                Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>Your account has been successfully activated. You can now log in and start using our koi veterinary services.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                Type = "ActivateUser",
                IsDelete = false,
                CreateDate = DateTime.Now,
                CreateBy = "System",
                UpdateDate = DateTime.Now,
                UpdateBy = "System"
            },
            new EmailTemplate
            {
                EmailTemplateId = new Guid("46db13e8-7899-432b-ae8c-febc15d0f1b2"),
                Subject = "Account Deactivation",
                Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>Your account has been deactivated. If you think this is a mistake, please contact our support team.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                Type = "DeactivateUser",
                IsDelete = false,
                CreateDate = DateTime.Now,
                CreateBy = "System",
                UpdateDate = DateTime.Now,
                UpdateBy = "System"
            },
             new EmailTemplate
             {
                 EmailTemplateId = new Guid("f1d7a678-87b5-4c12-b5f2-ae9e4a3d9b8a"),
                 Subject = "Service Update Notification",
                 Body = @"
                <html>
                <body>
                    <p>Dear {{UserName}},</p>
                    <p>Your requested koi service titled '{{ServiceTitle}}' has been successfully updated.</p>
                    <p>If you have any questions or need further assistance, please feel free to reach out to us.</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                 Type = "UpdateService",
                 IsDelete = false,
                 CreateDate = DateTime.Now,
                 CreateBy = "System",
                 UpdateDate = DateTime.Now,
                 UpdateBy = "System"
             },
              new EmailTemplate
              {
                  EmailTemplateId = new Guid("1f7d6a3c-523d-44b6-b9c5-6f3d3c9874f1"),
                  Subject = "Service Deactivation Notification",
                  Body = @"
                <html>
                <body>
                    <p>Hello {{UserName}},</p>
                    <p>Your service titled '{{ServiceTitle}}' has been deactivated for the following reason:</p>
                    <p>{{DeactivationReason}}</p>
                    <p>Best regards,<br>Koi Veterinary Service Center</p>
                </body>
                </html>",
                  Type = "DeactivateService",
                  IsDelete = false,
                  CreateDate = DateTime.Now,
                  CreateBy = "System",
                  UpdateDate = DateTime.Now,
                  UpdateBy = "System"
              }
        );
    }
}


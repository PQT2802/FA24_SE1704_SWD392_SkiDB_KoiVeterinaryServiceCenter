using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.EmailTemplate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using KVSC.Application.Interface.IService;
using Cursus_Data.Models.Entities;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailTemplateController : ControllerBase
    {
        private readonly IEmailTemplateService _emailTemplateService;

        public EmailTemplateController(IEmailTemplateService emailTemplateService)
        {
            _emailTemplateService = emailTemplateService;
        }

        [HttpPost("upload-template")]
        public async Task<IResult> UploadTemplate([FromForm] UploadEmailTemplateRequest request)
        {
            if (request.TemplateFile == null || request.TemplateFile.Length == 0)
            {
                var error = Error.Validation("InvalidFile", "Invalid file upload");
                return ResultExtensions.ToProblemDetails(Result.Failure(error));
            }

            // Read the HTML file content
            string htmlContent;
            using (var streamReader = new StreamReader(request.TemplateFile.OpenReadStream()))
            {
                htmlContent = await streamReader.ReadToEndAsync();
            }

            // Create a new EmailTemplate object
            var emailTemplate = new EmailTemplate
            {
                Subject = request.Subject,
                Body = htmlContent,
                Type = request.Type,
                IsDelete = false,
                CreateDate = DateTime.UtcNow,
                CreateBy = "System",
                UpdateDate = DateTime.UtcNow,
                UpdateBy = "System"
            };

            // Call the service method to save the template
            var result = await _emailTemplateService.SaveEmailTemplateAsync(emailTemplate);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Template uploaded successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpPost("send-template-email")]
        public async Task<IResult> SendTemplateEmail([FromBody] SendTemplateEmailRequest request)
        {
            try
            {
                // Generate the email body using the template type and placeholders
                var emailBody = await _emailTemplateService.GenerateEmailBody(request.TemplateType, request.Placeholders);

                // Create a MailObject with the necessary details
                var mailObject = new MailObject
                {
                    ToMailIds = new List<string> { request.ToEmail },
                    Subject = $"Email from template {request.TemplateType}",
                    Body = emailBody,
                    IsBodyHtml = true
                };

                // Send the email
                var sendResult = await _emailTemplateService.SendMail(mailObject);
                return sendResult.IsSuccess
                    ? ResultExtensions.ToSuccessDetails(sendResult, "Email sent successfully")
                    : ResultExtensions.ToProblemDetails(sendResult);
            }
            catch (Exception ex)
            {
                return ResultExtensions.ToProblemDetails(Result.Failure(Error.Failure("SendError", $"Failed to send email: {ex.Message}")));
            }
        }
    }
}

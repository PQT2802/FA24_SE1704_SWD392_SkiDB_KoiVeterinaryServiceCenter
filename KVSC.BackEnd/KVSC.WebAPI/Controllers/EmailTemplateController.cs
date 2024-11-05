using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.EmailTemplate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using KVSC.Application.Interface.IService;
using Cursus_Data.Models.Entities;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using KVSC.Application.Implement.Service;
using KVSC.Infrastructure.DTOs.Firebase.GetImage;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailTemplateController : ControllerBase
    {
        private readonly IEmailTemplateService _emailTemplateService;
        private readonly IFirebaseService _firebaseService;

        public EmailTemplateController(IEmailTemplateService emailTemplateService, IFirebaseService firebaseService)
        {
            _emailTemplateService = emailTemplateService;
            _firebaseService = firebaseService;
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

            // Process images: Upload and retrieve Firebase URLs
            Dictionary<string, string> imagePlaceholders = new Dictionary<string, string>();
            foreach (var image in request.Images)
            {
                // Upload image to Firebase and get the file path
                var uploadResult = await _firebaseService.UploadImageAsync(image, request.Type);
                if (uploadResult.IsFailure)
                {
                    return ResultExtensions.ToProblemDetails(uploadResult);
                }

                var filePath = (string)uploadResult.Object;

                // Retrieve the image URL from Firebase using GetImageAsync
                var getImageRequest = new GetImageRequest(filePath);
                var imageUrlResult = await _firebaseService.GetImageAsync(getImageRequest);
                if (imageUrlResult.IsFailure)
                {
                    return ResultExtensions.ToProblemDetails(imageUrlResult);
                }

                var imageUrl = ((GetImageResponse)imageUrlResult.Object).ImageUrl;

                // Generate placeholder key based on the image file name without extension
                var placeholderKey = Path.GetFileNameWithoutExtension(image.FileName);
                imagePlaceholders[$"{{{placeholderKey}}}"] = imageUrl;
            }

            // Replace image placeholders in the HTML content with Firebase URLs
            foreach (var placeholder in imagePlaceholders)
            {
                htmlContent = htmlContent.Replace(placeholder.Key, placeholder.Value);
            }

            // Create a new EmailTemplate object with updated HTML content
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

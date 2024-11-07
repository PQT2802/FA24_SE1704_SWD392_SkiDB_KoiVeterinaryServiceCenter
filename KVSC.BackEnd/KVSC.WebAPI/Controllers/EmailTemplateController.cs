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
using System.Text.Json;

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

            // Process images: Upload and store Firebase file paths without replacing in the HTML
            Dictionary<string, string> imagePlaceholders = new Dictionary<string, string>();
            foreach (var image in request.Images)
            {
                // Upload image to Firebase and get the file path
                var uploadResult = await _firebaseService.UploadImageAsync(image, "EmailTemplate");
                if (uploadResult.IsFailure)
                {
                    return ResultExtensions.ToProblemDetails(uploadResult);
                }

                var filePath = (string)uploadResult.Object;

                // Store the placeholder key and its corresponding Firebase file path
                var placeholderKey = Path.GetFileNameWithoutExtension(image.FileName);
                imagePlaceholders[placeholderKey] = filePath;
            }

            // Create a new EmailTemplate object with placeholders intact
            var emailTemplate = new EmailTemplate
            {
                Subject = request.Subject,
                Body = htmlContent,
                Type = request.Type,
                IsDelete = false,
                CreateDate = DateTime.UtcNow,
                CreateBy = "System",
                UpdateDate = DateTime.UtcNow,
                UpdateBy = "System",
                ImageMappingsJson = JsonSerializer.Serialize(imagePlaceholders) // Save mappings as JSON
            };

            // Save the template
            var result = await _emailTemplateService.SaveEmailTemplateAsync(emailTemplate);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Template uploaded successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("get-template/{templateType}")]
        public async Task<Result> GetTemplate(string templateType)
        {
            // Retrieve template by type
            var templateResult = await _emailTemplateService.GetTemplateByTypeAsync(templateType);
            if (templateResult.IsFailure)
            {
                return templateResult;
            }

            var emailTemplate = templateResult.Object as EmailTemplate;
            var htmlContent = emailTemplate.Body;

            // Deserialize image mappings JSON
            var imageMappings = JsonSerializer.Deserialize<Dictionary<string, string>>(emailTemplate.ImageMappingsJson);

            // Process each image mapping and retrieve Firebase URL
            foreach (var mapping in imageMappings)
            {
                var getImageRequest = new GetImageRequest(mapping.Value); // Firebase path
                var imageUrlResult = await _firebaseService.GetImageAsync(getImageRequest);
                if (imageUrlResult.IsSuccess)
                {
                    var imageUrl = ((GetImageResponse)imageUrlResult.Object).ImageUrl;
                    htmlContent = htmlContent.Replace($"{{{mapping.Key}}}", imageUrl); // Replace placeholder with actual URL
                }
            }

            return Result.SuccessWithObject(htmlContent);
        }



        [HttpPost("send-template-email")]
        public async Task<IResult> SendTemplateEmail([FromBody] SendTemplateEmailRequest request)
        {
            try
            {
                // Retrieve the template with replaced placeholders
                var templateResult = await GetTemplate(request.TemplateType);
                if (templateResult.IsFailure)
                {
                    return ResultExtensions.ToProblemDetails(templateResult);
                }

                var emailBody = templateResult.Object as string;

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

using Microsoft.AspNetCore.Http;

namespace KVSC.Infrastructure.DTOs.EmailTemplate
{
    public class UploadEmailTemplateRequest
    {
        public string Subject { get; set; }
        public string Type { get; set; }
        public IFormFile TemplateFile { get; set; }
    }
}

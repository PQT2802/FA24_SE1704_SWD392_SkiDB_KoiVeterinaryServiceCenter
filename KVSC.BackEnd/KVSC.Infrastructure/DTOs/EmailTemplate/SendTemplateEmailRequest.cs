namespace KVSC.Infrastructure.DTOs.EmailTemplate
{
    public class SendTemplateEmailRequest
    {
        public string ToEmail { get; set; }
        public string TemplateType { get; set; }
        public Dictionary<string, string> Placeholders { get; set; } = new Dictionary<string, string>();
    }
}

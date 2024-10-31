namespace KVSC.Infrastructure.DTOs.EmailTemplate;

public class MailObject
{
    public List<string> ToMailIds { get; set; } = new List<string>();
    public string Subject { get; set; } = "";
    public string Body { get; set; } = "";
    public bool IsBodyHtml { get; set; } = true;
    public List<string> Attachments { get; set; } = new List<string>();
}
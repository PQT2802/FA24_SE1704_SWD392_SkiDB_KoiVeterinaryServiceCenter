using KVSC.Infrastructure.DTOs.EmailTemplate;

namespace KVSC.Application.Interface.IService;

public interface IEmailTemplateService
{
    Task<string> GenerateEmailBody(string emailTemplateType, Dictionary<string, string> placeholders);
    Task<dynamic> SendMail(MailObject mailObject);
}
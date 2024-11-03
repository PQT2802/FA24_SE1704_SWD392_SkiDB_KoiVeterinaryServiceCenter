using Cursus_Data.Models.Entities;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.EmailTemplate;

namespace KVSC.Application.Interface.IService;

public interface IEmailTemplateService
{
    Task<string> GenerateEmailBody(string emailTemplateType, Dictionary<string, string> placeholders);
    Task<dynamic> SendMail(MailObject mailObject);
    Task<Result> SaveEmailTemplateAsync(EmailTemplate emailTemplate);
}
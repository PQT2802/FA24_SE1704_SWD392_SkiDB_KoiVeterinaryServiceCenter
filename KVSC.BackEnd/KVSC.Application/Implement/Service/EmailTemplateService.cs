using System.Net.Mail;
using Cursus_Data.Models.Entities;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.EmailTemplate;
using KVSC.Infrastructure.Implement.Repositories;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using Microsoft.Extensions.Configuration;

namespace KVSC.Application.Implement.Service;

public class EmailTemplateService : IEmailTemplateService
{
    private readonly IEmailTemplateRepository _emailTemplateRepsository;
    private readonly IConfiguration _configuration;
    
    public EmailTemplateService( IEmailTemplateRepository emailTemplateRepsository, IConfiguration configuration) 
    {
        _emailTemplateRepsository = emailTemplateRepsository;
        _configuration = configuration;
    }
    
    public async Task<string> GenerateEmailBody(string emailTemplateType, Dictionary<string, string> placeholders)
    {
        var emailTemplate = await _emailTemplateRepsository.GetEmailTemplateByTypeAsync(emailTemplateType);
        if (emailTemplate == null)
            throw new Exception("Email template not found");

        string body = emailTemplate.Body;
        foreach (var placeholder in placeholders)
        {
            body = body.Replace($"{{{placeholder.Key}}}", placeholder.Value);
        }

        return body;
    }
    
    public async Task<dynamic> SendMail(MailObject mailObject)
    {
        try
        {
            string smtpServer = _configuration["SMTP:Server"];
            int port = int.Parse(_configuration["SMTP:Port"]);
            string senderEmail = _configuration["MailService:MailSender"];
            string password = _configuration["MailService:PasswordSender"];
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(senderEmail);
                mailObject.ToMailIds.ForEach(x =>
                    {
                        mail.To.Add(x);
                    }
                );
                mail.Subject = mailObject.Subject;
                mail.Body = mailObject.Body;
                mail.IsBodyHtml = mailObject.IsBodyHtml;
                mailObject.Attachments.ForEach(x =>
                {
                    mail.Attachments.Add(new Attachment(x));
                });
                using (SmtpClient smtp = new SmtpClient(smtpServer, port))
                {
                    smtp.Credentials = new System.Net.NetworkCredential(senderEmail, password);
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(mail);
                    return Result.Success();
                }
            }
        }
        catch (Exception ex)
        {

            return ex.Message;
        }

    }
    public async Task<Result> SaveEmailTemplateAsync(EmailTemplate emailTemplate)
    {
        try
        {
            await _emailTemplateRepsository.AddEmailTemplateAsync(emailTemplate); // Use the new Add method
            return Result.Success();
        }
        catch (Exception ex)
        {
            return Result.Failure(Error.Failure("SaveError", $"Failed to save email template: {ex.Message}"));
        }
    }
}
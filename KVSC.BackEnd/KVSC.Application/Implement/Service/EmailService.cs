using Cursus_Data.Models.Entities;
using KVSC.Application.Interface.IService;
using KVSC.Infrastructure.DTOs.EmailTemplate;
using KVSC.Infrastructure.Interface.IRepositories;

namespace KVSC.Application.Implement.Service;

public class EmailService : IEmailService
{
    private readonly IMailRepository _mailRepository;
    private readonly IEmailTemplateRepository _emailTemplateRepository;
    private readonly IEmailTemplateService _emailTemplateService;

    public EmailService(IMailRepository mailRepository, IEmailTemplateRepository emailTemplateRepository,
        IEmailTemplateService emailTemplateService)
    {
        _mailRepository = mailRepository;
        _emailTemplateRepository = emailTemplateRepository;
        _emailTemplateService = emailTemplateService;
    }

    public async Task<string> SendAccountActivationEmail(string toEmail, string userName, string activationLink)
    {
        // Retrieve the Account Activation email template
        var template = await _emailTemplateRepository.GetEmailTemplateByTypeAsync("AccountActivation");
        if (template == null)
        {
            throw new Exception("Account Activation email template not found.");
        }

        // Set up placeholders for dynamic content in the email body
        var placeholders = new Dictionary<string, string>
        {
            { "UserName", userName },
            { "ActivationLink", activationLink }
        };

        // Generate the email body using the template and placeholders
        var body = await _emailTemplateService.GenerateEmailBody(template.Type, placeholders);

        // Create the mail object to send
        var mailObject = new MailObject
        {
            ToMailIds = new List<string> { toEmail },
            Subject = template.Subject,
            Body = body,
            IsBodyHtml = true // Assuming the email body should be HTML formatted
        };

        // Send the email using the email template service
        var sendResult = await _emailTemplateService.SendMail(mailObject);

      

        // Log the sent email in the UserEmail table
        var userEmailRecord = new UserEmail
        {
            UserID = Guid.NewGuid(), // Replace with actual user ID if available
            EmailTemplateId = template.EmailTemplateId,
            Description = "Account Activation",
            CreateDate = DateTime.Now,
            UpdateDate = DateTime.Now,
            CreateBy = "System",
            UpdateBy = "System"
        };

        // Save the email record
        await _emailTemplateRepository.SaveEmailSending(userEmailRecord);

        return "Account activation email sent successfully.";
    }

    public Task<string> SendForgetPasswordEmail(string toEmail, string userName, string resetLink)
    {
        throw new NotImplementedException();
    }
}


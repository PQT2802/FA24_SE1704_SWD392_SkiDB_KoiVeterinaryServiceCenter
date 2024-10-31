using Cursus_Data.Models.Entities;

namespace KVSC.Infrastructure.Interface.IRepositories;

public interface IEmailTemplateRepository
{
    public Task<EmailTemplate> GetEmailTemplateByTypeAsync(string type);


    public Task<dynamic> SaveEmailSending(UserEmail userEmail);
}
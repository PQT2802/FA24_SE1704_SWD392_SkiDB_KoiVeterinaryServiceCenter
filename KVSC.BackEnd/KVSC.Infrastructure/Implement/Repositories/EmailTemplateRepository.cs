using Cursus_Data.Models.Entities;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KVSC.Infrastructure.Implement.Repositories;

public class EmailTemplateRepository : GenericRepository<EmailTemplate>, IEmailTemplateRepository
{
    public EmailTemplateRepository(KVSCContext context) : base(context) { }

    public async Task<EmailTemplate> GetEmailTemplateByTypeAsync(string type)
    {
        return await _context.EmailTemplates.FirstOrDefaultAsync(et => et.Type == type);
    }
    
    public async Task<dynamic> SaveEmailSending(UserEmail userEmail)
    {
        _context.UserEmails.Add(userEmail);
        return await _context.SaveChangesAsync();
    }
    public async Task AddEmailTemplateAsync(EmailTemplate emailTemplate)
    {
        await _context.EmailTemplates.AddAsync(emailTemplate);
        await _context.SaveChangesAsync();
    }
}

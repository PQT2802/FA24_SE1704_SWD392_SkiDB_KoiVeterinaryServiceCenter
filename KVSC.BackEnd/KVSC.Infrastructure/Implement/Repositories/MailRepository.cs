using Cursus_Data.Models.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KVSC.Infrastructure.Implement.Repositories;

public class MailRepository : GenericRepository<UserEmail>, IMailRepository
{
    public MailRepository(KVSCContext context) : base(context) { }


    public async Task<UserEmail> GetConfirmationMailByUserIdAsync(Guid userId, Guid emailTemplateId)
    {
        return await _context.UserEmails
            .Where(ue => ue.UserID == userId && ue.EmailTemplateId == emailTemplateId)
            .OrderByDescending(ue => ue.CreateDate)
            .FirstOrDefaultAsync();
    }

    
}

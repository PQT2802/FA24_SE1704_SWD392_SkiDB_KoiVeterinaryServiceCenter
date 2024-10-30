using Cursus_Data.Models.Entities;

namespace KVSC.Infrastructure.Interface.IRepositories;

public interface IMailRepository
{
    public Task<UserEmail> GetConfirmationMailByUserIdAsync(Guid userId, Guid emailTemplateId);
}
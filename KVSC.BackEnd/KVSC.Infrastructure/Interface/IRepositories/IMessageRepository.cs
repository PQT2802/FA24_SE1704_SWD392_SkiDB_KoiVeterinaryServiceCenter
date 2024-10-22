using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IMessageRepository
    {
        Task<Message> CreateMessageAsync(Message message);
        Task<List<Message>> GetMessagesAsync(Guid senderId, Guid recipientId);
        Task<List<ConversationDto>> GetConversationsAsync(Guid userId);
    }
}

using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.DTOs.Chat;
using KVSC.Infrastructure.Interface.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly KVSCContext _context;

        public MessageRepository(KVSCContext context)
        {
            _context = context;
        }

        // CREATE
        public async Task<Message> CreateMessageAsync(Message message)
        {
            _context.Messages.Add(message);
            await _context.SaveChangesAsync();
            return message;
        }
        public async Task<List<Message>> GetMessagesAsync(Guid senderId, Guid recipientId)
        {
            return await _context.Messages
                .Where(m => (m.SenderId == senderId && m.RecipientId == recipientId) ||
                             (m.SenderId == recipientId && m.RecipientId == senderId))
                .OrderBy(m => m.Timestamp)
                .ToListAsync();
        }
        public async Task<List<ConversationDto>> GetConversationsAsync(Guid userId)
        {
            return await _context.Messages
                .Where(m => m.SenderId == userId || m.RecipientId == userId)
                .GroupBy(m => m.SenderId == userId ? m.RecipientId : m.SenderId)
                .Select(g => new ConversationDto
                {
                    RecipientId = g.Key,
                    LastMessage = g.OrderByDescending(m => m.Timestamp).FirstOrDefault().Content,
                    Timestamp = g.Max(m => m.Timestamp)
                })
                .OrderByDescending(c => c.Timestamp)
                .ToListAsync();
        }
    }
}

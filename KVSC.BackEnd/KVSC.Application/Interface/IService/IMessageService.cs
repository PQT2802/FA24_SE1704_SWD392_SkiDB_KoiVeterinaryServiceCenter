using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Chat.AddMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IMessageService
    {
        Task<Result> CreateMessageAsync(CreateMessageRequest createMessageRequest);
        Task<Result> GetMessagesAsync(Guid senderId, Guid recipientId);
        Task<Result> GetConversationsAsync(Guid userId);
        Task<Result> GetMessagesAsync(Guid senderId, Guid recipientId, Guid appointmentId);
    }
}

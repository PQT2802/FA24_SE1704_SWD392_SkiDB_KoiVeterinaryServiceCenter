using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Message;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Message.AddMessage;

namespace KVSC.Application.Service.Implement
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task<ResponseDto<CreateMessageResponse>> SendMessage(CreateMessageRequest request)
        {
            return await _messageRepository.CreateMessage(request);
        }

        public async Task<ResponseDto<MessageModel>> GetMessages(Guid senderId, Guid recipientId)
        {
            return await _messageRepository.GetMessages(senderId, recipientId);
        }
        public async Task<ResponseDto<ConversationModel>> GetConversationAsync(Guid userId)
        {
            return await _messageRepository.GetConversationAsync(userId);
        }

    }
}

using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Chat.AddMessage;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Implement.Service
{
    public class MessageService : IMessageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MessageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> CreateMessageAsync(CreateMessageRequest createMessageRequest)
        {
            if (string.IsNullOrWhiteSpace(createMessageRequest.Content))
            {
                return Result.Failure(ChatErrorMessage.FieldIsEmpty());
            }

            var message = new Message
            {
                Id = Guid.NewGuid(),
                SenderId = createMessageRequest.SenderId,
                RecipientId = createMessageRequest.RecipientId,
                Content = createMessageRequest.Content,
                Timestamp = DateTime.UtcNow.ToLocalTime()
            };

            // Lưu tin nhắn vào database
            await _unitOfWork.MessageRepository.CreateMessageAsync(message);
            var response = new CreateResponse { Id = message.Id };
            return Result.SuccessWithObject(response);
        }
        public async Task<Result> GetMessagesAsync(Guid senderId, Guid recipientId)
        {
            var messages = await _unitOfWork.MessageRepository.GetMessagesAsync(senderId, recipientId);

            if (messages == null || !messages.Any())
            {
                return Result.Failure(ChatErrorMessage.NoMessagesFound());
            }
            var messageResponses = new List<CreateMessageResponse>();

            foreach (var message in messages)
            {
                var senderName = await _unitOfWork.UserRepository.GetByIdAsync(message.SenderId); // Lấy tên người gửi
                var recipientName = await _unitOfWork.UserRepository.GetByIdAsync(message.RecipientId); // Lấy tên người nhận

                var messageResponse = new CreateMessageResponse
                {
                    SenderId = message.SenderId,
                    SenderName = senderName.FullName,
                    RecipientId = message.RecipientId,
                    RecipientName = recipientName.FullName,
                    Content = message.Content,
                    Timestamp = message.Timestamp
                };

                messageResponses.Add(messageResponse);
            }
            return Result.SuccessWithObject(messageResponses);
        }
        public async Task<Result> GetConversationsAsync(Guid userId)
        {
            var conversations = await _unitOfWork.MessageRepository.GetConversationsAsync(userId);
            if (conversations == null || !conversations.Any())
            {
                return Result.Failure(ChatErrorMessage.NoMessagesFound());
            }
            foreach (var conversation in conversations)
            {
                var recipient = await _unitOfWork.UserRepository.GetByIdAsync(conversation.RecipientId);
                conversation.RecipientName = recipient.FullName;
            }
            return Result.SuccessWithObject(conversations);
        }
    }
}

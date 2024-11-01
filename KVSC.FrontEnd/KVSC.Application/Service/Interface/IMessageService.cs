using KVSC.Infrastructure.DTOs.Message;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Message.AddMessage;

namespace KVSC.Application.Service.Interface
{
    public interface IMessageService
    {
        Task<ResponseDto<CreateMessageResponse>> SendMessage(CreateMessageRequest request);
        Task<ResponseDto<MessageModel>> GetMessages(Guid senderId, Guid recipientId);
        Task<ResponseDto<ConversationModel>> GetConversationAsync(Guid userId);
        Task<ResponseDto<MessageModel>> GetMessages(Guid customerId, Guid veterinarianId, Guid appointmentId);

    }
}

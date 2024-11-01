using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Chat.AddMessage;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.Firebase.GetImage;
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
            Guid veterinarianId;
            Guid customerId;
            var veterinarian = await _unitOfWork.VeterinarianScheduleRepository.GetVeterinarianByUserIdAsync(senderId);
            if (veterinarian != null)
            {
                veterinarianId = veterinarian.Id; // sender là Veterinarian
                customerId = recipientId;         // recipient là Customer
            }
            else
            {
                veterinarian = await _unitOfWork.VeterinarianScheduleRepository.GetVeterinarianByUserIdAsync(recipientId);
                veterinarianId = veterinarian.Id; // recipient là Veterinarian
                customerId = senderId;            // sender là Customer
            }
            var appointment = await _unitOfWork.AppointmentRepository.GetLatestAppointmentAsync(customerId, veterinarianId);
            if (appointment == null || DateTime.UtcNow.Date > appointment.AppointmentDate.AddDays(1) || appointment.Status != "InProgress")
            {
                return Result.Failure(MessageErrorMessage.InvalidDateChat());
            }

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
                /*============================================lay anh==========================================================*/
                var getimg = new GetImageRequest(senderName.ProfilePictureUrl);
                var petSenderImg = await _unitOfWork.FirebaseRepository.GetImageAsync(getimg);
                /*============================================lay anh==========================================================*/
                var messageResponse = new CreateMessageResponse
                {
                    AvatarUrl = petSenderImg.ImageUrl,
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
        /*==================lay message cho appointment =============================*/
        public async Task<Result> GetMessagesAsync(Guid customerId, Guid veterinarianId, Guid appointmentId)
        {
            var senderId = customerId;
            var veterinarian = await _unitOfWork.UserRepository.GetVeterinarianByVeterinarianIdAsync(veterinarianId) ;
            if(veterinarian == null)
            {
                return Result.Failure(ChatErrorMessage.NoMessagesFound());
            }
            var appointment = await _unitOfWork.AppointmentRepository.GetAppointmentByIdAsync(appointmentId);
            // Lấy các tin nhắn mà có ngày giống với ngày cuộc hẹn
            var messages = await _unitOfWork.MessageRepository.GetMessagesAsync(senderId, veterinarian.UserId);
            var filteredMessages = messages.Where(m => m.Timestamp.Date == appointment.AppointmentDate.Date).ToList();

            if (filteredMessages == null || !filteredMessages.Any())
            {
                return Result.Failure(ChatErrorMessage.NoMessagesFound());
            }

            var messageResponses = new List<CreateMessageResponse>();

            foreach (var message in filteredMessages)
            {
                var senderName = await _unitOfWork.UserRepository.GetByIdAsync(message.SenderId); // Lấy tên người gửi
                var recipientName = await _unitOfWork.UserRepository.GetByIdAsync(message.RecipientId); // Lấy tên người nhận

                /*============================================lay anh==========================================================*/
                var getimg = new GetImageRequest(senderName.ProfilePictureUrl);
                var petSenderImg = await _unitOfWork.FirebaseRepository.GetImageAsync(getimg);
                /*============================================lay anh==========================================================*/

                var messageResponse = new CreateMessageResponse
                {
                    AvatarUrl = petSenderImg.ImageUrl,
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
                var getimg = new GetImageRequest(recipient.ProfilePictureUrl ?? string.Empty);
                var petRecipientImg = await _unitOfWork.FirebaseRepository.GetImageAsync(getimg);
                conversation.AvatarUrl = petRecipientImg.ImageUrl;
                conversation.RecipientName = recipient.FullName;
            }
            return Result.SuccessWithObject(conversations);
        }
    }
}

using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Chat.AddMessage;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        // POST: api/messages
        [HttpPost]
        public async Task<IResult> CreateMessage([FromBody] CreateMessageRequest createMessageRequest)
        {
            Result result = await _messageService.CreateMessageAsync(createMessageRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Message sent successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("{senderId}/{recipientId}")]
        public async Task<IResult> GetMessages(Guid senderId, Guid recipientId)
        {
            var result = await _messageService.GetMessagesAsync(senderId, recipientId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Get message successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpGet("{customerId}/{veterinarianId}/{appointmentId}")]
        public async Task<IResult> GetMessages(Guid customerId, Guid veterinarianId, Guid appointmentId)
        {
            var result = await _messageService.GetMessagesAsync(customerId, veterinarianId, appointmentId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Get message script successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpGet("conversations/{userId}")]
        public async Task<IResult> GetConversations(Guid userId)
        {
            var result = await _messageService.GetConversationsAsync(userId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Get message successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}

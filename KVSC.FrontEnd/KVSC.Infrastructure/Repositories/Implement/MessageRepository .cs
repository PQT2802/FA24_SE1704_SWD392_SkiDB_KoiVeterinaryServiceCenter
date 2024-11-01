using KVSC.Infrastructure.DTOs.Message;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.Repositories.Interface;
using System.Text.Json;
using KVSC.Infrastructure.DTOs.Message.AddMessage;

namespace KVSC.Infrastructure.Repositories.Implement
{
    public class MessageRepository : IMessageRepository
    {
        private readonly HttpClient _httpClient;

        public MessageRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDto<CreateMessageResponse>> CreateMessage(CreateMessageRequest request)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var response = await _httpClient.PostAsJsonAsync("api/messages", request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                return new ResponseDto<CreateMessageResponse>
                {
                    IsSuccess = false,
                    Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                    Message = "An error occurred while sending the message."
                };
            }

            var message = await response.Content.ReadFromJsonAsync<CreateMessageResponse>(options);
            return new ResponseDto<CreateMessageResponse>
            {
                IsSuccess = true,
                Data = message,
                Message = "Message sent successfully."
            };
        }

        public async Task<ResponseDto<MessageModel>> GetMessages(Guid senderId, Guid recipientId)
        {
            
            var response = await _httpClient.GetAsync($"api/messages/{senderId}/{recipientId}");

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                return new ResponseDto<MessageModel>
                {
                    IsSuccess = false,
                    Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                    Message = "An error occurred while retrieving messages."
                };
            }

            var messages = await response.Content.ReadFromJsonAsync<MessageModel>();
            return new ResponseDto<MessageModel>
            {
                IsSuccess = true,
                Data = messages,
                Message = "Messages retrieved successfully."
            };
        }
        public async Task<ResponseDto<MessageModel>> GetMessages(Guid customerId, Guid veterinarianId, Guid appointmentId)
        {
            var response = await _httpClient.GetAsync($"api/messages/{customerId}/{veterinarianId}/{appointmentId}");

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                return new ResponseDto<MessageModel>
                {
                    IsSuccess = false,
                    Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                    Message = "An error occurred while retrieving messages."
                };
            }

            var messages = await response.Content.ReadFromJsonAsync<MessageModel>();
            return new ResponseDto<MessageModel>
            {
                IsSuccess = true,
                Data = messages,
                Message = "Messages retrieved successfully."
            };
        }
        public async Task<ResponseDto<ConversationModel>> GetConversationAsync(Guid userId)
        {
            try
            {
                // Gửi yêu cầu GET đến API
                var response = await _httpClient.GetAsync($"api/Messages/conversations/{userId}");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseContent, options);

                    return new ResponseDto<ConversationModel>
                    {
                        IsSuccess = false,
                        Data = null,
                        Errors = errorResponse?.Errors ?? new List<ErrorDetail>(),
                        Message = "An error occurred during fetching the conversation."
                    };
                }

                var messages = await response.Content.ReadFromJsonAsync<ConversationModel>(options);
                return new ResponseDto<ConversationModel>
                {
                    IsSuccess = true,
                    Data = messages,
                    Message = "Conversation fetched successfully."
                };
            }
            catch (HttpRequestException httpEx)
            {
                return new ResponseDto<ConversationModel>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Request error: {httpEx.Message}"
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto<ConversationModel>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"An unexpected error occurred: {ex.Message}"
                };
            }
        }
    }
}

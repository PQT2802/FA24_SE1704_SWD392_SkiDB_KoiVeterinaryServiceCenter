using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Message.AddMessage;
using KVSC.Infrastructure.DTOs.Message;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IdentityModel.Tokens.Jwt;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Veterinarian
{
    public class ChatModel : PageModel
    {
        private readonly IMessageService _messageService;

        [BindProperty]
        public CreateMessageRequest CreateMessageRequest { get; set; } = new CreateMessageRequest();
        public MessageModel Messages { get; set; } = new MessageModel();
        public ConversationModel Conversations { get; set; } = new ConversationModel();
        public Guid CurrentUserId { get; set; }
        public Guid CurrentRecipientId { get; set; }

        public string RecipientName { get; set; }
        public ChatModel(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<IActionResult> OnGetAsync(Guid? recipientId, string recipientName)
        {
            // Lấy token từ session
            RecipientName = recipientName;

            var token = HttpContext.Session.GetString("Token");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/SignIn");
            }

            // Giải mã token để lấy userId (người dùng hiện tại)
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;

            if (!Guid.TryParse(userIdClaimString, out Guid currentUserId))
            {
                ModelState.AddModelError(string.Empty, "Unable to decode userId from token..");
                return Page();
            }

            // Gọi service để lấy danh sách cuộc hội thoại
            var conversationResult = await _messageService.GetConversationAsync(currentUserId);
            if (conversationResult.IsSuccess)
            {
                Conversations = conversationResult.Data ?? new ConversationModel();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Unable to load conversation list.");
            }

            //If no recipientId is given, default recipient is the first conversation.
            if (!recipientId.HasValue && Conversations.Extensions != null && Conversations.Extensions.Data.Any())
            {
                CurrentRecipientId = Conversations.Extensions.Data.First().RecipientId;
                RecipientName = Conversations.Extensions.Data.First().RecipientName;
            }
            else
            {
                CurrentRecipientId = recipientId ?? Guid.Empty;
            }

            // Lấy tin nhắn giữa currentUserId và recipientId
            if (CurrentRecipientId != Guid.Empty)
            {
                var messageResult = await _messageService.GetMessages(currentUserId, CurrentRecipientId);
                if (messageResult.IsSuccess)
                {
                    Messages = messageResult.Data ?? new MessageModel();
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Could not load message.");
                }
            }

            // Lưu lại thông tin userId hiện tại
            CurrentUserId = currentUserId;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var result = await _messageService.SendMessage(CreateMessageRequest);
            if (result.IsSuccess)
            {
                return RedirectToPage();
            }

            ModelState.AddModelError(string.Empty, "Unable to send message.");
            return Page();
        }
    }
}

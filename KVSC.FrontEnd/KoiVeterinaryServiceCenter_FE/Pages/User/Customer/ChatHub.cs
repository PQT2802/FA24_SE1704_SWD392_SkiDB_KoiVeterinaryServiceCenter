using Microsoft.AspNetCore.SignalR;
using System.IdentityModel.Tokens.Jwt;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Customer
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Guid senderId, Guid recipientId, string content)
        {
            var message = new
            {
                SenderId = senderId,
                RecipientId = recipientId,
                Content = content,
                Timestamp = DateTime.Now
            };

            await Clients.Group(senderId.ToString()).SendAsync("ReceiveMessage", message);
            await Clients.Group(recipientId.ToString()).SendAsync("ReceiveMessage", message);
        }

        public async Task JoinRoom(Guid userId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userId.ToString());
        }
    }
}

using KVSC.Infrastructure.DTOs.User;
using Microsoft.AspNetCore.SignalR;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Customer
{
    public class ChatHub : Hub
    {
        public static Dictionary<Guid, bool> UserStatus = new();
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
            await Clients.All.SendAsync("UpdateUserStatus", userId, true);
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var token = Context.GetHttpContext().Session.GetString("Token");

            if (string.IsNullOrEmpty(token)) return;

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;

            if (Guid.TryParse(userIdClaimString, out Guid parsedUserId))
            {
                UserStatus[parsedUserId] = false; // Đánh dấu người dùng offline
                await Clients.All.SendAsync("UpdateUserStatus", parsedUserId, false);
            }

            await base.OnDisconnectedAsync(exception);
        }
        public override async Task OnConnectedAsync()
        {
            var token = Context.GetHttpContext().Session.GetString("Token");

            if (string.IsNullOrEmpty(token)) return; // Ngăn chặn nếu không có token

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaimString = jwtToken.Claims.FirstOrDefault(c => c.Type == "userId")?.Value;

            if (Guid.TryParse(userIdClaimString, out Guid parsedUserId))
            {
                UserStatus[parsedUserId] = true; // Đánh dấu người dùng online

                // Gửi danh sách người dùng đang online cho người mới đăng nhập
                await Clients.Caller.SendAsync("ReceiveOnlineUsers", UserStatus.Where(u => u.Value).Select(u => u.Key).ToList());

                // Thông báo cho tất cả người khác về trạng thái online của người dùng này
                await Clients.Others.SendAsync("UpdateUserStatus", parsedUserId, true);
            }

            await base.OnConnectedAsync();
        }
    }
}

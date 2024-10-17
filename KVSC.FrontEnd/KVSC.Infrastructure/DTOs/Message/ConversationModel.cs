using KVSC.Infrastructure.DTOs.Service.AddService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Message
{
    public class ConversationModel
    {
        public Extensions<List<ConversationDataList>> Extensions { get; set; }
       
    }
    public class ConversationDataList
    {
        public Guid RecipientId { get; set; }  // ID của cuộc hội thoại
        public string AvatarUrl { get; set; }
        public string RecipientName { get; set; }
        public string LastMessage { get; set; }  // Nội dung tin nhắn cuối cùng
        public DateTime Timestamp { get; set; }  // Thời gian của tin nhắn cuối cùng

    }
}

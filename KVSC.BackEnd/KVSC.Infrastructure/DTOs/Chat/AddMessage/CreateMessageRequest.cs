using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Chat.AddMessage
{
    public class CreateMessageRequest
    {
        public Guid SenderId { get; set; }  // ID của customer
        public Guid RecipientId { get; set; }  // ID của veterinarian
        public string Content { get; set; }  // Nội dung tin nhắn
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Chat.AddMessage
{
    public class CreateMessageResponse
    {
        public Guid SenderId { get; set; } 
        public string SenderName { get; set; }
        public Guid RecipientId { get; set; } 
        public string RecipientName { get; set; }  
        public string Content { get; set; }  
        public DateTime Timestamp { get; set; }
    }
}

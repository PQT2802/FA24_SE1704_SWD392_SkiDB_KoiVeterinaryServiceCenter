using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Chat
{
    public class ConversationDto
    {
        public Guid RecipientId { get; set; }
        public string RecipientName { get; set; }
        public string LastMessage { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

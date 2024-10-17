using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Message
{
    public class MessageModel
    {
        public Extensions<List<MessageModelDataList>> Extensions { get; set; }
       
    }
    public class MessageModelDataList
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecipientId { get; set; }
        public string Content { get; set; }
        public string SenderName { get; set; }
        public string RecipientName { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

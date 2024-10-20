using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Common.Message
{
    public static class ChatErrorMessage
    {
        public static Error FieldIsEmpty()
          => Error.Validation("Chat.Empty", $"Message content cannot be empty");
        public static Error NoMessagesFound()
           => Error.Validation("Chat.NotFound", "Message not found.");
    }
}

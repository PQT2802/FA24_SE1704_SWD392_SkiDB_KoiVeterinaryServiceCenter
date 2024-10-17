using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public class ErrorResponseWithId
    {
        // Bỏ qua trường $id
        [JsonExtensionData]
        public Dictionary<string, object> AdditionalData { get; set; }

        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public Dictionary<string, List<string>> Errors { get; set; }
    }
}

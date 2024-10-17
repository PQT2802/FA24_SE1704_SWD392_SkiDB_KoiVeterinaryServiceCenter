using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public class Extensions<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
    }
    
    public class ApiResponseDto<T>
    {
        public int StatusCode { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public Extensions<T> Extensions { get; set; }
    }
}

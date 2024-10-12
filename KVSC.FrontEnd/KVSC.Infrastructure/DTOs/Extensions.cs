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
}

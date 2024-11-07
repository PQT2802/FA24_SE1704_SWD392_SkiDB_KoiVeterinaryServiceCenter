using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public class ModalViewModel
    {
        public string? Title { get; set; } = default!;
        public string Message { get; set; } = default!;
        public string? Type { get; set; } = default!;
    }
}

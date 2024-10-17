using KVSC.Infrastructure.DTOs.Appointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public class ResponseDto<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }
        public List<ErrorDetail>? Errors { get; set; }

        public ResponseDto()
        {
            Errors = new List<ErrorDetail>();
        }
    }

    public class ErrorDetail
    {
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // e.g. Validation, NotFound
    }
}

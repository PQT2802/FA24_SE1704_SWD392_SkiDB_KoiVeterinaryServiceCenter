﻿using KVSC.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common
{
    public  record Error
    {
        public static readonly Error None = new(string.Empty, string.Empty,ErrorType.Failure);
        private Error(string code, string description, ErrorType errorType)
        {
            Code = code;
            Description = description;
            Type = errorType;
        }
        public string Code { get;}
        public string Description { get; }
        public ErrorType Type { get;}

        public static Error NotFound(string code,string description)
            => new(code, description,ErrorType.NotFound);

        public static Error Validation(string code, string description)
            => new(code, description, ErrorType.Validation);
        public static Error Conflict(string code, string description)
            => new(code, description, ErrorType.Conflict);
        public static Error Failure(string code, string description)
            => new(code, description, ErrorType.Failure);
    }
}

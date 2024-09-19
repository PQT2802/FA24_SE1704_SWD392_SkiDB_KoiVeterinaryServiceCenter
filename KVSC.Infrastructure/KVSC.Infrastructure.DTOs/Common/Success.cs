﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common
{
    public class Success<T>
    {
        public int StatusCode { get; }
        public string Title { get; }
        public string Type { get; }
        public T Data { get; }

        public IDictionary<string, object?> Extensions { get; }

        public Success(int statusCode, string title, string type, T data, IDictionary<string, object?> extensions = null)
        {
            StatusCode = statusCode;
            Title = title;
            Type = type;
            Data = data;
            Extensions = extensions ?? new Dictionary<string, object?>();
        }
    }
}

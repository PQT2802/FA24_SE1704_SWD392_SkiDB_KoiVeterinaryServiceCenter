using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KVSC.Application.KVSC.Application.Common.Result
{
    public class Result<T>
    {
        private Result(bool isSuccess, T data, Error error)
        {
            if (isSuccess && error != Error.None ||
                !isSuccess && error == Error.None)
            {
                throw new ArgumentException("Invalid error state", nameof(error));
            }

            IsSuccess = isSuccess;
            Data = data;
            Error = error;
        }

        public bool IsSuccess { get; }

        public bool IsFailure => !IsSuccess;

        public T Data { get; }

        public Error Error { get; }

        // Factory method for success with data
        public static Result<T> Success(T data) => new(true, data, Error.None);

        // Factory method for failure with error
        public static Result<T> Failure(Error error) => new(false, default!, error);
    }
}

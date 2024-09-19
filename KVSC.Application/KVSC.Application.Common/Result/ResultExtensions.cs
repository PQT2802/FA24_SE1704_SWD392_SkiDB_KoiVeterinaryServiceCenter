using KVSC.Domain.Enum;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KVSC.Application.KVSC.Application.Common.Result
{
    public static class ResultExtensions
    {
        public static TReturn Match<TData, TReturn>(
            this Result<TData> result,
            Func<TData, TReturn> onSuccess,
            Func<Error, TReturn> onFailure)
        {
            return result.IsSuccess ? onSuccess(result.Data) : onFailure(result.Error);
        }

        public static IResult ToProblemDetails<T>(this Result<T> result)
        {
            if (result.IsSuccess)
            {
                throw new InvalidOperationException();
            }

            return Results.Problem(
                statusCode: GetStatusCode(result.Error.Type),
                title: GetTitle(result.Error.Type),
                type: GetType(result.Error.Type),
                extensions: new Dictionary<string, object?>
                {
                    { "error", new[] { result.Error } }
                }
            );

            static int GetStatusCode(ErrorType errorType) =>
                errorType switch
                {
                    ErrorType.Validation => StatusCodes.Status400BadRequest,
                    ErrorType.NotFound => StatusCodes.Status404NotFound,
                    ErrorType.Conflict => StatusCodes.Status409Conflict,
                    _ => StatusCodes.Status500InternalServerError
                };

            static string GetTitle(ErrorType errorType) =>
                errorType switch
                {
                    ErrorType.Validation => "Bad Request",
                    ErrorType.NotFound => "Not Found",
                    ErrorType.Conflict => "Conflict",
                    _ => "Server Failure"
                };

            static string GetType(ErrorType errorType) =>
                errorType switch
                {
                    ErrorType.Validation => "https://tools.ietf.org/html/rfc7231#section-6.5.1",  // 400 Bad Request
                    ErrorType.NotFound => "https://tools.ietf.org/html/rfc7231#section-6.5.4",   // 404 Not Found
                    ErrorType.Conflict => "https://tools.ietf.org/html/rfc7231#section-6.5.8",   // 409 Conflict
                    _ => "https://tools.ietf.org/html/rfc7231#section-6.6.1"                     // 500 Internal Server Error
                };
        }

        public static IResult ToSuccessDetails<T>(this Result<T> result,string message)
        {
            if (!result.IsSuccess)
            {
                throw new InvalidOperationException();
            }

            return result.Data == null
                ? Results.NoContent() // 204 No Content
                : Results.Ok(
                    new Success<T>(
                        statusCode: StatusCodes.Status200OK,
                        title: "Operation Successful",
                        type: "https://tools.ietf.org/html/rfc7231#section-6.3.1", // 200 OK
                        data: result.Data,
                        extensions: new Dictionary<string, object?>
                        {
                            {"message", message },
                            { "data", result.Data }
                        }
                    )
                );
        }
    }
}

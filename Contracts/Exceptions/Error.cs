using System.Text.Json;

namespace Contracts.Exceptions;

public enum ErrorCode
{
    BadRequest = 400,
    BookNotFound = 404,
    InternalServerError = 500,
}

public class ErrorResponse
{
    public ErrorCode ErrorCode { get; set; }
    public string? Message { get; set; }
}

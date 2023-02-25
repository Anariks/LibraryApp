namespace Contracts.ApiDTO;

public enum ErrorCode
{
    BadRequest = 40000,
    BookNotFound = 40401,
    InternalServerError = 50000,
    DbFailureError = 50001
}

public class ErrorResponse
{
    public ErrorCode Code { get; init; }
    public string Message { get; init; }
}

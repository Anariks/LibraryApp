using Contracts.Exceptions;

namespace Data.Exceptions;

public class LibException : Exception
{
    public ErrorCode ErrorCode { get; }

    public LibException(ErrorCode errorCode)
        : this(errorCode, null) { }

    public LibException(ErrorCode errorCode, string message)
        : base(message)
    {
        ErrorCode = errorCode;
    }
}

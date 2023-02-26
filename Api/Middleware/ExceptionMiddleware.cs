using System.Net;
using System.Text.Json;
using Contracts.Exceptions;
using Data.Exceptions;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (LibException e)
        {
            await HandleExceptionAsync(context, e, e.ErrorCode);
        }
        catch (Exception e)
        {
            await HandleExceptionAsync(context, e);
        }
    }

    private async Task HandleExceptionAsync(
        HttpContext context,
        Exception e,
        ErrorCode code = ErrorCode.InternalServerError
    )
    {
        _logger.LogError("{type} , {e}", e.GetType(), e.Message);
        var message = e.Message;

        if (!(e is LibException))
            message = "Something went wrong, sorry..";

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;
        var error = new ErrorResponse { ErrorCode = code, Message = message };
        await context.Response.WriteAsync(JsonSerializer.Serialize(error));
    }
}

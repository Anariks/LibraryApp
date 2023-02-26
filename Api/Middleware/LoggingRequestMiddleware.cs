using System.Net;
using System.Text.Json;
using Contracts.Logging;
using Newtonsoft.Json;

public class LoggingRequestMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public LoggingRequestMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        await LogRequest(context);
        await _next(context);
    }

    private async Task LogRequest(HttpContext context)
    {
        if (context.Request.ContentLength == null)
            return;

        LogRequest request = new();

        context.Request.EnableBuffering();
        request.Type = context.Request.Method.ToString();

        request.Headers = context.Request.Headers.Select(k => k.ToString()).ToList();

        request.Body = await new StreamReader(context.Request.Body).ReadToEndAsync();
        context.Request.Body.Position = 0;

        _logger.LogInformation(JsonConvert.SerializeObject(request));
    }
}

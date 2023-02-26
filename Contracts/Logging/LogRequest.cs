namespace Contracts.Logging;

public class LogRequest
{
    public string Type { get; set; }
    public List<string> Headers { get; set; }
    public string Body { get; set; }
}

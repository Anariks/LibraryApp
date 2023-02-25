using Contracts.Interfaces;

namespace Business.Configuration;

public class LibConfiguration : ILibConfiguration
{
    public string SecretKey { get; init; }
}

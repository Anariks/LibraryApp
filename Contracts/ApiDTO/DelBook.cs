using Contracts.Database;

namespace Contracts.ApiDTO;

public class DelBookByIdRequest
{
    public int Id { get; init; }
    public string Secret { get; init; }
}

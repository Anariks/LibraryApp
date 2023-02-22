namespace Contracts.ApiDTO;

public class Rating
{
    public int Id { get; init; }
    public int BookId { get; init; }
    public float Score { get; init; }

    // public virtual Book Book { get; init; }
}

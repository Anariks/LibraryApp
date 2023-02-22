namespace Contracts.ApiDTO;

public class ReviewDTO
{
    public int Id { get; init; }
    public string Message { get; init; }

    public int BookId { get; init; }
    public string Reviewer { get; init; }

    // public virtual Book Book { get; init; }
}

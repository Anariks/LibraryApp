namespace Contracts.ApiDTO;

public class BookDTO
{
    public int Id { get; init; }
    public string Title { get; init; }
    public string Content { get; init; }
    public string Author { get; init; }
    public string Genre { get; init; }

    // public virtual List<Review> Reviews { get; init; }
    // public virtual List<Rating> Ratings { get; init; }
}

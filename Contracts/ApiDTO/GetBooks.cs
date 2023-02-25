using Contracts.Database;

namespace Contracts.ApiDTO;

public class GetRecommendedBooksRequest
{
    public string Genre { get; init; }
}

public class GetBooksAndOrderRequest
{
    public string Order { get; init; }
}

public class GetBooksResponse
{
    public int Id { get; init; }
    public string Title { get; init; }
    public string Author { get; init; }
    public decimal Rating { get; init; }
    public int RevieswsNumber { get; init; }

    public static explicit operator GetBooksResponse(Book book)
    {
        return new GetBooksResponse
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            Rating = (book.Ratings.Any()) ? book.Ratings.Average(rt => rt.Score) : 0,
            RevieswsNumber = book.Reviews.Count()
        };
    }
}

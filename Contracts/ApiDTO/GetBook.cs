using Contracts.Database;

namespace Contracts.ApiDTO;

public class GetBookByIdRequest
{
    public int Id { get; init; }
}

public class GetBookByIdResponse
{
    public int Id { get; init; }
    public string Title { get; init; }
    public string Author { get; init; }
    public string Cover { get; init; }
    public string Content { get; init; }
    public decimal Rating { get; init; }
    public List<ReviewResponse> Reviews { get; init; }

    public static explicit operator GetBookByIdResponse(Book book)
    {
        return new GetBookByIdResponse
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            Cover = book.Cover,
            Content = book.Content,
            Rating = (book.Ratings.Any()) ? book.Ratings.Average(rt => rt.Score) : 0,
            Reviews = book.Reviews.Select(review => (ReviewResponse)review).ToList()
        };
    }
}

public class ReviewResponse
{
    public int Id { get; init; }
    public string Message { get; init; }

    public string Reviewer { get; init; }

    public static explicit operator ReviewResponse(Review review)
    {
        return new ReviewResponse
        {
            Id = review.Id,
            Message = review.Message,
            Reviewer = review.Reviewer
        };
    }
}

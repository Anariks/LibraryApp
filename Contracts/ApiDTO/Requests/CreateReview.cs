using Contracts.Database;

namespace Contracts.ApiDTO.Requests;

public class CreateReviewRequest
{
    public int Id { get; set; }
    public string Message { get; init; }
    public string Reviewer { get; init; }

    public static implicit operator Review(CreateReviewRequest request) =>
        new Review
        {
            BookId = request.Id,
            Message = request.Message,
            Reviewer = request.Reviewer
        };
}

public class CreateReviewResponse
{
    public int Id { get; init; }

    public static explicit operator CreateReviewResponse(Review review) =>
        new CreateReviewResponse { Id = review.Id };
}

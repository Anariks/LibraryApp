using Contracts.Database;

namespace Contracts.ApiDTO;

public class CreateRateRequest
{
    public int Id { get; set; }
    public int Score { get; init; }

    public static implicit operator Rating(CreateRateRequest request) =>
        new Rating { BookId = request.Id, Score = request.Score };
}

// public class CreateRateResponse
// {
//     public int Id { get; init; }

//     public static explicit operator CreateRateResponse(Rating rating) =>
//         new CreateRateResponse { Id = rating.Id };
// }

using Contracts.Database;

namespace Contracts.ApiDTO.Requests;

public class CreateBookRequestDto
{
    public int Id { get; init; }
    public string Title { get; init; }
    public string Cover { get; init; }
    public string Content { get; init; }
    public string Genre { get; init; }
    public string Author { get; init; }

    // public static explicit operator BookDto(Book book)
    // {
    //     return new BookDto
    //     {
    //         Id = book.Id,
    //         Title = book.Title,
    //         Author = book.Author,
    //         // Rating = (book.Ratings.Any()) ? book.Ratings.Average(rt => rt.Score) : 0,
    //         Rating = (book.Ratings.Any()) ? book.Ratings.Average(rt => rt.Score) : 0,
    //         RevieswsNumber = book.Reviews.Count()
    //     };
    // }
}

public class CreateBookResponseDto
{
    public int Id { get; init; }
}

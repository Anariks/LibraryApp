using Contracts.Database;

namespace Contracts.ApiDTO.Requests;

public class CreateBookRequest
{
    public int Id { get; init; }
    public string Title { get; init; }
    public string Cover { get; init; }
    public string Content { get; init; }
    public string Genre { get; init; }
    public string Author { get; init; }

    public static implicit operator Book(CreateBookRequest book)
    {
        return new Book
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author,
            Cover = book.Cover,
            Content = book.Content,
            Genre = book.Genre
        };
    }
}

public class CreateBookResponse
{
    public int Id { get; init; }

    public static explicit operator CreateBookResponse(Book book)
    {
        return new CreateBookResponse { Id = book.Id };
    }
}

using System.ComponentModel.DataAnnotations;

namespace Contracts.Database;

public class Book
{
    [Key]
    public int Id { get; init; }
    public string Title { get; init; }
    public string Cover { get; init; }
    public string Content { get; init; }
    public string Author { get; init; }
    public string Genre { get; init; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contracts.Database;

public class Book
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    public string Title { get; init; }
    public string Cover { get; init; }
    public string Content { get; init; }
    public string Author { get; init; }
    public string Genre { get; init; }

    // [InverseProperty("Book")]
    public virtual List<Review> Reviews { get; init; }
    public virtual List<Rating> Ratings { get; init; }
}

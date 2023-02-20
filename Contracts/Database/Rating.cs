using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contracts.Database;

public class Rating
{
    [Key]
    public int Id { get; init; }

    [ForeignKey(nameof(Book))]
    public int BookId { get; init; }
    public float Score { get; init; }
}

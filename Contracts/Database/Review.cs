using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contracts.Database;

public class Review
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    public string? Message { get; init; }

    [ForeignKey("Book")]
    public int BookId { get; init; }
    public string? Reviewer { get; init; }
}

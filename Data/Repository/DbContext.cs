using Contracts.Database;
using Microsoft.EntityFrameworkCore;

namespace Data.Database;

public class LibDbContext : DbContext
{
    public DbSet<Book> Books { get; init; }
    public DbSet<Review> Reviews { get; init; }
    public DbSet<Rating> Ratings { get; init; }

    public LibDbContext()
        : base() { }

    public LibDbContext(DbContextOptions<LibDbContext> options)
        : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("Library");
    }
}

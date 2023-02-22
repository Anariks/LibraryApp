using Contracts.Database;
using Contracts.Interfaces;
using Data.Database;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository;

public class LibRepository : ILibRepository
{
    private readonly LibDbContext _context;

    public LibRepository() { }

    public LibRepository(LibDbContext dbContext)
    {
        dbContext.Database.EnsureCreated();
        _context = dbContext;
    }

    public async Task<List<Book>> GetAllBooks(string orderParam)
    {
        return await _context.Books
            .Include(b => b.Ratings)
            .Include(b => b.Reviews)
            .OrderBy(orderParam)
            .ToListAsync();
    }

    // public <IQueryable> GetAllBooks()
    // {
    //     return _context.Books.Include(b => b.Ratings).Include(b => b.Reviews);
    // }

    public List<Book> GetBooksByCondition(string condition)
    {
        throw new NotImplementedException();
    }
}

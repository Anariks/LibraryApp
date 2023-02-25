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

    public async Task<Book> SaveOrUpdateBook(Book book)
    {
        _context.Books.Update(book);
        await _context.SaveChangesAsync();

        if (book.Id == 0)
            return book;
        // return await _context.Books.LastAsync();

        return book;
    }

    public async Task<List<Book>> GetAllBooks(string orderParam)
    {
        return await _context.Books
            .Include(b => b.Ratings)
            .Include(b => b.Reviews)
            .OrderBy(orderParam)
            .ToListAsync();
    }

    public async Task<List<Book>> GetRecommendedBooks(string filterParam)
    {
        var result = _context.Books
            .Where(b => b.Genre.ToLower().Contains(filterParam.ToLower()) && b.Reviews.Count() > 10)
            .OrderByDescending(b => b.Ratings.Average(x => x.Score))
            .Take(10)
            .Include(b => b.Ratings)
            .Include(b => b.Reviews);

        return await result.ToListAsync();
    }

    public async Task<Book> GetById(int id)
    {
        return await _context.Books
            .Include(b => b.Ratings)
            .Include(b => b.Reviews)
            .FirstOrDefaultAsync(b => b.Id == id);
    }

    public async Task DelById(int id)
    {
        Book? book = await _context.Books.FindAsync(id);

        if (book == null)
            throw new InvalidOperationException("Such a book was not found");

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
    }

    public async Task<Review> SaveReview(Review review)
    {
        Book? book = await _context.Books.FindAsync(review.BookId);

        if (book == null)
            throw new InvalidOperationException("Such a book was not found");

        await _context.Reviews.AddAsync(review);
        await _context.SaveChangesAsync();

        return review;
    }

    public async Task SaveRate(Rating rating)
    {
        Book? book = await _context.Books.FindAsync(rating.BookId);

        if (book == null)
            throw new InvalidOperationException("Such a book was not found");

        await _context.Ratings.AddAsync(rating);
        await _context.SaveChangesAsync();
    }
}

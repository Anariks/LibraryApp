namespace Contracts.Interfaces;
using System.Collections.Generic;
using Contracts.Database;

public interface ILibRepository
{
    // public List<Book> GetAllBooks(string paramToOrder);
    public Task<List<Book>> GetAllBooks(string param);

    // public IQueryable GetAllBooks(string paramToOrder);

    // public Task<Book> GetBookById(int id, CancellationToken cancellationToken);
    List<Book> GetBooksByCondition(string condition);

    // IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    // void Add(T entity);
    // void AddRange(IEnumerable<T> entities);
    // void Remove(T entity);
    // void RemoveRange(IEnumerable<T> entities);
}

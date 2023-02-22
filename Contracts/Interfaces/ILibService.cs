using Contracts.ApiDTO.GetAllBooks;
using Contracts.Database;

namespace Contracts.Interfaces;

public interface ILibService
{
    public Task<List<BookDto>> GetAllBooks(string param);
    // public BookDTO GetBookById(int id);

    // ... ... ...
}

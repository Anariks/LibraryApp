using Contracts.ApiDTO.GetAllBooks;
using Contracts.ApiDTO.Requests;
using Contracts.Database;

namespace Contracts.Interfaces;

public interface ILibService
{
    // Task<List<BookDto>> GetAllBooks(string param);
    Task<List<BookDto>> GetAllBooks(GetBooksAndOrderRequest booksParam);
    Task<List<BookDto>> GetRecommendedBooks(GetRecommendedBooksRequest booksParam);
    Task<GetBookByIdResponse> GetBookById(int id);
    Task DelBookById(DelBookByIdRequest id);
    Task<CreateBookResponse> SaveOrUpdateBook(CreateBookRequest toProceed);

    Task<CreateReviewResponse> SaveReview(CreateReviewRequest toProceed);
    Task CreateRate(CreateRateRequest toProceed);
    // public BookDTO GetBookById(int id);

    // ... ... ...
}

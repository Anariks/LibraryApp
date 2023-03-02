using Contracts.ApiDTO;

namespace Contracts.Interfaces;

public interface ILibService
{
    Task<List<GetBooksResponse>> GetAllBooksAndOrder(GetBooksAndOrderRequest booksParam);
    Task<List<GetBooksResponse>> GetRecommendedBooks(GetRecommendedBooksRequest booksParam);
    Task<GetBookByIdResponse> GetBookById(int id);
    Task DelBookById(DelBookByIdRequest id);
    Task<CreateBookResponse> SaveOrUpdateBook(CreateBookRequest toProceed);
    Task<CreateReviewResponse> SaveReview(CreateReviewRequest toProceed);
    Task CreateRate(CreateRateRequest toProceed);
}

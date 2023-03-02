using System.Security;
using Business.Configuration;
using Contracts.ApiDTO;
using Contracts.Database;
using Contracts.Exceptions;
using Contracts.Interfaces;
using Data.Exceptions;
using Microsoft.Extensions.Options;

public class LibService : ILibService
{
    private readonly ILibRepository _libRepository;

    private readonly string _config;

    public LibService(ILibRepository libRepository, IOptions<LibConfiguration> config)
    {
        _libRepository = libRepository;
        _config = config.Value.SecretKey;
    }

    public async Task<List<GetBooksResponse>> GetAllBooksAndOrder(
        GetBooksAndOrderRequest booksParam
    )
    {
        var books = await _libRepository.GetAllBooksAndOrder(booksParam.Order);

        var booksDto = books.Select(book => (GetBooksResponse)book).ToList();
        return booksDto;
    }

    public async Task<List<GetBooksResponse>> GetRecommendedBooks(
        GetRecommendedBooksRequest booksParam
    )
    {
        var books = await _libRepository.GetRecommendedBooks(booksParam.Genre);

        var booksDto = books.Select(book => (GetBooksResponse)book).ToList();
        return booksDto;
    }

    public async Task<GetBookByIdResponse> GetBookById(int id)
    {
        Book? book = await _libRepository.GetById(id);

        var bookResponse = (book != null) ? (GetBookByIdResponse)book : null;
        return bookResponse;
    }

    public async Task DelBookById(DelBookByIdRequest delBookReq)
    {
        if (delBookReq.Secret != _config)
            throw new LibException(ErrorCode.Unauthorized, "Invalid secret key.");

        await _libRepository.DelById(delBookReq.Id);
    }

    public async Task<CreateBookResponse> SaveOrUpdateBook(CreateBookRequest bookToProceed)
    {
        var book = await _libRepository.SaveOrUpdateBook((Book)bookToProceed);

        return (CreateBookResponse)book;
    }

    public async Task<CreateReviewResponse> SaveReview(CreateReviewRequest toProceed)
    {
        var review = await _libRepository.SaveReview((Review)toProceed);

        return (CreateReviewResponse)review;
    }

    public async Task CreateRate(CreateRateRequest toProceed)
    {
        await _libRepository.SaveRate((Rating)toProceed);
    }
}

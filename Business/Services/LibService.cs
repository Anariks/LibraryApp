using AutoMapper;
using Contracts.ApiDTO.GetAllBooks;
using Contracts.Database;
using Contracts.Interfaces;
using Data.Repository;

public class LibService : ILibService
{
    private readonly ILibRepository _libRepository;
    private readonly IMapper _mapper;

    public LibService(ILibRepository libRepository, IMapper autoMapper)
    {
        _libRepository = libRepository;
        _mapper = autoMapper;
    }

    // public List<BookDto> GetAllBooks(string param)
    // {
    //     var query = _libRepository.GetAllBooks();
    //     return _mapper.ProjectTo<Contracts.ApiDTO.GetAllBooks.BookDto>(query).ToList();

    //     // return _mapper.Map<List<Contracts.ApiDTO.GetAllBooks.BookDto>>(books);
    // }

    public async Task<List<BookDto>> GetAllBooks(string OrderByParam)
    {
        var books = await _libRepository.GetAllBooks(OrderByParam);

        // var book = books[0];

        // var average = (book.Ratings.Count() > 0) ? book.Ratings.Average(rt => rt.Score) : 0;

        // var Average = books.Select( book => { if(book.Ratings.Count() > 0 ) book.Ratings.Average( xt => xt.Score);});
        // var Average = books.Select(book => book.Ratings.Select(rt => rt.Score).Average()).First();

        var booksDto = books.Select(book => (BookDto)book).ToList();

        return booksDto;
        // foreach (var book in books)
        // {
        //     var bookDto = (BookDto)book;
        // }
        //return _mapper.Map<List<Contracts.ApiDTO.GetAllBooks.BookDto>>(books);
    }

    // ... ... ...
}

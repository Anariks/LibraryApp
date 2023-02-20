using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LibraryController : ControllerBase
{
    public string GetName()
    {
        return "John Deer";
    }

    [Route("books")]
    [HttpGet]
    public string getBooks()
    {
        return "books";
    }

    [Route("books")]
    [HttpGet]
    public string getRecommendedBooks()
    {
        return "books";
    }
}

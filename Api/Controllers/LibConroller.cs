using Contracts.ApiDTO.Requests;
using Contracts.Database;
using Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/")]
public class LibController : ControllerBase
{
    private readonly ILibService _service;

    public LibController(ILibService libService)
    {
        _service = libService;
    }

    [HttpGet]
    [Route("books")]
    public async Task<IActionResult> getBooks(string? order = null)
    {
        var result = await _service.GetAllBooks(order);

        return Ok(result);
    }

    [HttpGet]
    [Route("recommended")]
    public async Task<IActionResult> getRecommendedBooks(string? filter = null)
    {
        // var result = await _service.GetRecommendedBooks(filter);

        return Ok("Here comes a books");
    }

    [HttpPost]
    [Route("books/save")]
    public async Task<IActionResult> saveOrUpdateBook([FromBody] CreateBookRequestDto bookToProceed)
    {
        if (!ModelState.IsValid)
        {
            throw new Exception("Invalid data");
        }
        return Ok((bookToProceed));
    }
}

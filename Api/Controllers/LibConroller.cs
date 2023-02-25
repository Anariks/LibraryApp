using System.Security;
using Business.Configuration;
using Contracts.ApiDTO.Requests;
using Contracts.Database;
using Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;

namespace Api.Controllers;

[ApiController]
[Route("api/")]
public class LibController : ControllerBase
{
    private readonly ILibService _service;

    // private readonly IOptions<LibConfiguration> _options;

    // private readonly LibConfiguration _config;

    public LibController(ILibService libService)
    {
        _service = libService;
        // _options = options;
    }

    [HttpGet]
    [Route("books")]
    public async Task<IActionResult> GetBooks([FromQuery] GetBooksAndOrderRequest getBooksRequest)
    {
        var result = await _service.GetAllBooks(getBooksRequest);

        return Ok(result);
    }

    [HttpGet]
    [Route("recommended")]
    public async Task<IActionResult> GetRecommendedBooks(
        [FromQuery] GetRecommendedBooksRequest getBooksRequest
    )
    {
        var result = await _service.GetRecommendedBooks(getBooksRequest);
        // public async Task<IActionResult> GetRecommendedBooks(string? filter = null)
        // {
        // var result = await _service.GetRecommendedBooks(filter);

        return Ok(result);
    }

    [HttpGet]
    [Route("books/{id}")]
    public async Task<IActionResult> GetBookById([FromRoute] GetBookByIdRequest getBookRequest)
    {
        var result = await _service.GetBookById(getBookRequest.Id);

        return Ok(result);
    }

    [HttpDelete]
    [Route("books/{id}")]
    public async Task<IActionResult> DelBookById([FromRoute] int id, [FromQuery] string secret)
    {
        var delBookByIdRequest = new DelBookByIdRequest() { Id = id, Secret = secret };
        try
        {
            await _service.DelBookById(delBookByIdRequest);

            return NoContent();
        }
        catch (SecurityException ex)
        {
            return Unauthorized(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    [Route("books/save")]
    public async Task<IActionResult> SaveOrUpdateBook([FromBody] CreateBookRequest bookToProceed)
    {
        var result = await _service.SaveOrUpdateBook(bookToProceed);
        return Ok((result));
    }

    // ### 6. Save a review for the book.
    // PUT https://{{baseUrl}}/api/books/{id}/review

    [HttpPut]
    [Route("books/{id}/review")]
    public async Task<IActionResult> SaveReview(
        [FromRoute] int id,
        [FromBody] CreateReviewRequest request
    )
    {
        request.Id = id;

        var result = await _service.SaveReview(request);

        return Ok(result);
    }

    // ### 7. Rate a book
    // PUT https://{{baseUrl}}/api/books/{id}/rate
    [HttpPut]
    [Route("books/{id}/rate")]
    public async Task<IActionResult> RateBook(
        [FromRoute] int id,
        [FromBody] CreateRateRequest request
    )
    {
        request.Id = id;

        await _service.CreateRate(request);

        return Ok();
    }
}

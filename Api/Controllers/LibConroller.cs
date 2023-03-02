using System.Security;
using Contracts.ApiDTO;
using Contracts.Interfaces;
using HybridModelBinding;
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
    public async Task<IActionResult> GetAllBooksAndOrder(
        [FromQuery] GetBooksAndOrderRequest getBooksRequest
    )
    {
        var result = await _service.GetAllBooksAndOrder(getBooksRequest);

        return Ok(result);
    }

    [HttpGet]
    [Route("recommended")]
    public async Task<IActionResult> GetRecommendedBooks(
        [FromQuery] GetRecommendedBooksRequest getBooksRequest
    )
    {
        var result = await _service.GetRecommendedBooks(getBooksRequest);

        return Ok(result);
    }

    [HttpGet]
    [Route("books/{id}")]
    public async Task<IActionResult> GetBookById([FromRoute] GetBookByIdRequest getBookRequest)
    {
        GetBookByIdResponse? result = await _service.GetBookById(getBookRequest.Id);

        if (result == null)
            return NotFound();

        return Ok(result);
    }

    [HttpDelete]
    [Route("books/{id}")]
    public async Task<IActionResult> DelBookById([FromHybrid] DelBookByIdRequest delBookByIdRequest)
    {
        await _service.DelBookById(delBookByIdRequest);
        return NoContent();
    }

    [HttpPost]
    [Route("books/save")]
    public async Task<IActionResult> SaveOrUpdateBook([FromBody] CreateBookRequest bookToProceed)
    {
        var result = await _service.SaveOrUpdateBook(bookToProceed);
        return Ok((result));
    }

    [HttpPut]
    [Route("books/{id}/review")]
    public async Task<IActionResult> SaveReview([FromHybrid] CreateReviewRequest request)
    {
        var result = await _service.SaveReview(request);

        return Ok(result);
    }

    [HttpPut]
    [Route("books/{id}/rate")]
    public async Task<IActionResult> RateBook([FromHybrid] CreateRateRequest request)
    {
        await _service.CreateRate(request);
        return Ok();
    }
}

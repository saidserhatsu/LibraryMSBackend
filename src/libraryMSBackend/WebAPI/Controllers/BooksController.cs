using Application.Features.Books.Commands.Create;
using Application.Features.Books.Commands.Delete;
using Application.Features.Books.Commands.Update;
using Application.Features.Books.Queries.GetById;
using Application.Features.Books.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBookCommand createBookCommand)
    {
        CreatedBookResponse response = await Mediator.Send(createBookCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBookCommand updateBookCommand)
    {
        UpdatedBookResponse response = await Mediator.Send(updateBookCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedBookResponse response = await Mediator.Send(new DeleteBookCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdBookResponse response = await Mediator.Send(new GetByIdBookQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBookQuery getListBookQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListBookListItemDto> response = await Mediator.Send(getListBookQuery);
        return Ok(response);
    }



    //[HttpGet("search")]
    //public async Task<IActionResult> SearchBooks([FromQuery] SearchCriteria criteria, [FromQuery] PageRequest pageRequest)
    //{
    //    // MediatR query'sini çaðýrýn
    //    var query = new SearchBooksQuery(criteria, pageRequest);
    //    var result = await Mediator.Send(query);

    //    return Ok(result);
    //}
    [HttpGet("search")]
    public async Task<IActionResult> SearchBooks(
        [FromQuery] string? bookTitle,  // Nullable
        [FromQuery] string? authorName,  // Nullable
        [FromQuery] string? authorSurname,  // Nullable
        [FromQuery] string? isbnCode,  // Nullable
        [FromQuery] PageRequest pageRequest)  // Sayfalama için
    {
        var searchCriteria = new SearchCriteria
        {
            BookTitle = bookTitle,
            AuthorName = authorName,
            AuthorSurname = authorSurname,
            BookISBNCode = isbnCode
        };

        var query = new SearchBooksQuery(searchCriteria, pageRequest);
        var result = await Mediator.Send(query);

        return Ok(result);
    }

}
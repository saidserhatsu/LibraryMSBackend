using Application.Features.EBooks.Commands.Create;
using Application.Features.EBooks.Commands.Delete;
using Application.Features.EBooks.Commands.Update;
using Application.Features.EBooks.Queries.FilterSearch;
using Application.Features.EBooks.Queries.GetById;
using Application.Features.EBooks.Queries.GetList;
using Application.Features.FinePayments.Queries.FilterSearch;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EBooksController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromForm] CreateEBookCommand createEBookCommand)
    {
        CreatedEBookResponse response = await Mediator.Send(createEBookCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromForm] UpdateEBookCommand updateEBookCommand)
    {
        UpdatedEBookResponse response = await Mediator.Send(updateEBookCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedEBookResponse response = await Mediator.Send(new DeleteEBookCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdEBookResponse response = await Mediator.Send(new GetByIdEBookQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListEBookQuery getListEBookQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListEBookListItemDto> response = await Mediator.Send(getListEBookQuery);
        return Ok(response);
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchEBooks(
        [FromQuery(Name = "eBookTitle")] string? eBookTitle, // nullable
        [FromQuery(Name = "eBookIsbnCode")] string? eBookIsbnCode, // nullable
        [FromQuery(Name = "eBookAuthorName")] string? eBookAuthorName, // nullable
        [FromQuery] PageRequest pageRequest
    )
    {
        // Arama kriterleri oluþtur
        var searchCriteria = new SearchCriteria { EBookTitle = eBookTitle, EBookISBNCode = eBookIsbnCode, EBookAuthorName=eBookAuthorName };

        // MediatR query'sini oluþtur
        var query = new SearchEBookQuery(searchCriteria, pageRequest);

        // Query'yi gönder ve sonuçlarý al
        var result = await Mediator.Send(query);

        return Ok(result);
    }
}

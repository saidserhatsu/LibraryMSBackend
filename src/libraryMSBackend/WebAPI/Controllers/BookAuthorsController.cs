using Application.Features.BookAuthors.Commands.Create;
using Application.Features.BookAuthors.Commands.Delete;
using Application.Features.BookAuthors.Commands.Update;
using Application.Features.BookAuthors.Queries.GetById;
using Application.Features.BookAuthors.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookAuthorsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBookAuthorCommand createBookAuthorCommand)
    {
        CreatedBookAuthorResponse response = await Mediator.Send(createBookAuthorCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBookAuthorCommand updateBookAuthorCommand)
    {
        UpdatedBookAuthorResponse response = await Mediator.Send(updateBookAuthorCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedBookAuthorResponse response = await Mediator.Send(new DeleteBookAuthorCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdBookAuthorResponse response = await Mediator.Send(new GetByIdBookAuthorQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBookAuthorQuery getListBookAuthorQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListBookAuthorListItemDto> response = await Mediator.Send(getListBookAuthorQuery);
        return Ok(response);
    }
}
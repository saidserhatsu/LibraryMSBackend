using Application.Features.FavoriteBooks.Commands.Create;
using Application.Features.FavoriteBooks.Commands.Delete;
using Application.Features.FavoriteBooks.Commands.Update;
using Application.Features.FavoriteBooks.Queries.GetById;
using Application.Features.FavoriteBooks.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FavoriteBooksController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateFavoriteBookCommand createFavoriteBookCommand)
    {
        CreatedFavoriteBookResponse response = await Mediator.Send(createFavoriteBookCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateFavoriteBookCommand updateFavoriteBookCommand)
    {
        UpdatedFavoriteBookResponse response = await Mediator.Send(updateFavoriteBookCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedFavoriteBookResponse response = await Mediator.Send(new DeleteFavoriteBookCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdFavoriteBookResponse response = await Mediator.Send(new GetByIdFavoriteBookQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListFavoriteBookQuery getListFavoriteBookQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListFavoriteBookListItemDto> response = await Mediator.Send(getListFavoriteBookQuery);
        return Ok(response);
    }
}
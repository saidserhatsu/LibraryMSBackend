using Application.Features.MagazineAuthors.Commands.Create;
using Application.Features.MagazineAuthors.Commands.Delete;
using Application.Features.MagazineAuthors.Commands.Update;
using Application.Features.MagazineAuthors.Queries.GetById;
using Application.Features.MagazineAuthors.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MagazineAuthorsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateMagazineAuthorCommand createMagazineAuthorCommand)
    {
        CreatedMagazineAuthorResponse response = await Mediator.Send(createMagazineAuthorCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateMagazineAuthorCommand updateMagazineAuthorCommand)
    {
        UpdatedMagazineAuthorResponse response = await Mediator.Send(updateMagazineAuthorCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedMagazineAuthorResponse response = await Mediator.Send(new DeleteMagazineAuthorCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdMagazineAuthorResponse response = await Mediator.Send(new GetByIdMagazineAuthorQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListMagazineAuthorQuery getListMagazineAuthorQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListMagazineAuthorListItemDto> response = await Mediator.Send(getListMagazineAuthorQuery);
        return Ok(response);
    }
}
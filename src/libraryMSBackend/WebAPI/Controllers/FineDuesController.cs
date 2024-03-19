using Application.Features.FineDues.Commands.Create;
using Application.Features.FineDues.Commands.Delete;
using Application.Features.FineDues.Commands.Update;
using Application.Features.FineDues.Queries.GetById;
using Application.Features.FineDues.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FineDuesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateFineDueCommand createFineDueCommand)
    {
        CreatedFineDueResponse response = await Mediator.Send(createFineDueCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateFineDueCommand updateFineDueCommand)
    {
        UpdatedFineDueResponse response = await Mediator.Send(updateFineDueCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedFineDueResponse response = await Mediator.Send(new DeleteFineDueCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdFineDueResponse response = await Mediator.Send(new GetByIdFineDueQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListFineDueQuery getListFineDueQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListFineDueListItemDto> response = await Mediator.Send(getListFineDueQuery);
        return Ok(response);
    }
}
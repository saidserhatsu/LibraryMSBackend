using Application.Features.FeedBacks.Commands.Create;
using Application.Features.FeedBacks.Commands.Delete;
using Application.Features.FeedBacks.Commands.Update;
using Application.Features.FeedBacks.Queries.GetById;
using Application.Features.FeedBacks.Queries.GetList;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FeedBacksController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<CreatedFeedBackResponse>> Add([FromForm] CreateFeedBackCommand command)
    {
        CreatedFeedBackResponse response = await Mediator.Send(command);

        return CreatedAtAction(nameof(GetById), new { response.Id }, response);
    }

    [HttpPut]
    public async Task<ActionResult<UpdatedFeedBackResponse>> Update([FromBody] UpdateFeedBackCommand command)
    {
        UpdatedFeedBackResponse response = await Mediator.Send(command);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<DeletedFeedBackResponse>> Delete([FromRoute] Guid id)
    {
        DeleteFeedBackCommand command = new() { Id = id };

        DeletedFeedBackResponse response = await Mediator.Send(command);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetByIdFeedBackResponse>> GetById([FromRoute] Guid id)
    {
        GetByIdFeedBackQuery query = new() { Id = id };

        GetByIdFeedBackResponse response = await Mediator.Send(query);

        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetListFeedBackQuery>> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListFeedBackQuery query = new() { PageRequest = pageRequest };

        GetListResponse<GetListFeedBackListItemDto> response = await Mediator.Send(query);

        return Ok(response);
    }
}
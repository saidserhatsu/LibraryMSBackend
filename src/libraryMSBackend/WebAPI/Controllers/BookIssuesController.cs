using Application.Features.BookIssues.Commands.Create;
using Application.Features.BookIssues.Commands.Delete;
using Application.Features.BookIssues.Commands.Update;
using Application.Features.BookIssues.Queries.GetById;
using Application.Features.BookIssues.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Application.Features.BookIssues.Queries.Statistics;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookIssuesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBookIssueCommand createBookIssueCommand)
    {
        CreatedBookIssueResponse response = await Mediator.Send(createBookIssueCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBookIssueCommand updateBookIssueCommand)
    {
        UpdatedBookIssueResponse response = await Mediator.Send(updateBookIssueCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedBookIssueResponse response = await Mediator.Send(new DeleteBookIssueCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdBookIssueResponse response = await Mediator.Send(new GetByIdBookIssueQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBookIssueQuery getListBookIssueQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListBookIssueListItemDto> response = await Mediator.Send(getListBookIssueQuery);
        return Ok(response);
    }

    [HttpGet("monthly-statistics")]
    public async Task<IActionResult> GetBookIssueMonthlyStatistics()
    {
        var result = await Mediator.Send(new BookIssueMonthlyStatisticsQuery());
        return Ok(result);
    }
}
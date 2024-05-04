using Application.Features.FineDues.Commands.Create;
using Application.Features.FineDues.Commands.Delete;
using Application.Features.FineDues.Commands.Update;
using Application.Features.FineDues.Queries.GetById;
using Application.Features.FineDues.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Application.Features.FinePayments.Queries.FilterSearch;
using Domain.Entities;
using Application.Features.FineDues.Queries.FilterSearch;
using Domain.Enums;
using Application.Features.FineDues.Queries.Statistics;

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
    [HttpGet("search")]
    public async Task<IActionResult> SearchFineDues(
        [FromQuery(Name = "MemberFirstName")] string? memberFirstName, // nullable
        [FromQuery(Name = "MemberLastName")] string? memberLastName, // nullable
        [FromQuery] PageRequest pageRequest
    )
    {
        // Arama kriterleri oluþtur
        var searchCriteria = new SearchCriteria { MemberFirstName = memberFirstName, MemberLastName = memberLastName };

        // MediatR query'sini oluþtur
        var query = new SearchFineDueQuery(searchCriteria, pageRequest);

        // Query'yi gönder ve sonuçlarý al
        var result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("finedue/statistics")]
    public async Task<IActionResult> GetFineDueMoneyStatistics()
    {
        var result = await Mediator.Send(new FineDueMoneyStatisticsQuery());
        return Ok(result);
    }

}
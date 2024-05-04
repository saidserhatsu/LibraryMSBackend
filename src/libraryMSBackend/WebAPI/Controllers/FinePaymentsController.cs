using Application.Features.FinePayments.Commands.Create;
using Application.Features.FinePayments.Commands.Delete;
using Application.Features.FinePayments.Commands.Update;
using Application.Features.FinePayments.Queries.FilterSearch;
using Application.Features.FinePayments.Queries.GetById;
using Application.Features.FinePayments.Queries.GetList;
using Application.Features.FinePayments.Queries.Statistics;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinePaymentsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateFinePaymentCommand createFinePaymentCommand)
    {
        CreatedFinePaymentResponse response = await Mediator.Send(createFinePaymentCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateFinePaymentCommand updateFinePaymentCommand)
    {
        UpdatedFinePaymentResponse response = await Mediator.Send(updateFinePaymentCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedFinePaymentResponse response = await Mediator.Send(new DeleteFinePaymentCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdFinePaymentResponse response = await Mediator.Send(new GetByIdFinePaymentQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListFinePaymentQuery getListFinePaymentQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListFinePaymentListItemDto> response = await Mediator.Send(getListFinePaymentQuery);
        return Ok(response);
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchFinePayments(
        [FromQuery(Name = "MemberFirstName")] string? memberFirstName, // nullable
        [FromQuery(Name = "MemberLastName")] string? memberLastName, // nullable
        [FromQuery] PageRequest pageRequest
    )
    {
        // Arama kriterleri oluþtur
        var searchCriteria = new SearchCriteria { MemberFirstName = memberFirstName, MemberLastName = memberLastName };

        // MediatR query'sini oluþtur
        var query = new SearchFinePaymentQuery(searchCriteria, pageRequest);

        // Query'yi gönder ve sonuçlarý al
        var result = await Mediator.Send(query);

        return Ok(result);
    }

    [HttpGet("finePaymentMoney-statistics")] 
    public async Task<IActionResult> GetFinePaymentMoneyStatistics()
    {
        var result = await Mediator.Send(new FinePaymentMoneyStatisticsQuery());
        return Ok(result); 
    }
}

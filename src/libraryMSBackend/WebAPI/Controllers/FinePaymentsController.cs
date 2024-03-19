using Application.Features.FinePayments.Commands.Create;
using Application.Features.FinePayments.Commands.Delete;
using Application.Features.FinePayments.Commands.Update;
using Application.Features.FinePayments.Queries.GetById;
using Application.Features.FinePayments.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

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
}
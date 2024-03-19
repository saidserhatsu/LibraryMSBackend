using Application.Features.BookReservations.Commands.Create;
using Application.Features.BookReservations.Commands.Delete;
using Application.Features.BookReservations.Commands.Update;
using Application.Features.BookReservations.Queries.GetById;
using Application.Features.BookReservations.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookReservationsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBookReservationCommand createBookReservationCommand)
    {
        CreatedBookReservationResponse response = await Mediator.Send(createBookReservationCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBookReservationCommand updateBookReservationCommand)
    {
        UpdatedBookReservationResponse response = await Mediator.Send(updateBookReservationCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedBookReservationResponse response = await Mediator.Send(new DeleteBookReservationCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdBookReservationResponse response = await Mediator.Send(new GetByIdBookReservationQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBookReservationQuery getListBookReservationQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListBookReservationListItemDto> response = await Mediator.Send(getListBookReservationQuery);
        return Ok(response);
    }
}
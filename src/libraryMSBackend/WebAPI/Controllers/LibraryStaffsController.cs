using Application.Features.LibraryStaffs.Commands.Create;
using Application.Features.LibraryStaffs.Commands.Delete;
using Application.Features.LibraryStaffs.Commands.Update;
using Application.Features.LibraryStaffs.Queries.GetById;
using Application.Features.LibraryStaffs.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LibraryStaffsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLibraryStaffCommand createLibraryStaffCommand)
    {
        CreatedLibraryStaffResponse response = await Mediator.Send(createLibraryStaffCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLibraryStaffCommand updateLibraryStaffCommand)
    {
        UpdatedLibraryStaffResponse response = await Mediator.Send(updateLibraryStaffCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedLibraryStaffResponse response = await Mediator.Send(new DeleteLibraryStaffCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdLibraryStaffResponse response = await Mediator.Send(new GetByIdLibraryStaffQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListLibraryStaffQuery getListLibraryStaffQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListLibraryStaffListItemDto> response = await Mediator.Send(getListLibraryStaffQuery);
        return Ok(response);
    }
}
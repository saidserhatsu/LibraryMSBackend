using Application.Features.MemberSettings.Commands.Create;
using Application.Features.MemberSettings.Commands.Delete;
using Application.Features.MemberSettings.Commands.Update;
using Application.Features.MemberSettings.Queries.GetById;
using Application.Features.MemberSettings.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MemberSettingsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateMemberSettingCommand createMemberSettingCommand)
    {
        CreatedMemberSettingResponse response = await Mediator.Send(createMemberSettingCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateMemberSettingCommand updateMemberSettingCommand)
    {
        UpdatedMemberSettingResponse response = await Mediator.Send(updateMemberSettingCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        DeletedMemberSettingResponse response = await Mediator.Send(new DeleteMemberSettingCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        GetByIdMemberSettingResponse response = await Mediator.Send(new GetByIdMemberSettingQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListMemberSettingQuery getListMemberSettingQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListMemberSettingListItemDto> response = await Mediator.Send(getListMemberSettingQuery);
        return Ok(response);
    }
}
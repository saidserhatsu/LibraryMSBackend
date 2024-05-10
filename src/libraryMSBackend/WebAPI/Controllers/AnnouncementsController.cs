using Application.Features.Announcements.Commands.Create;
using Application.Features.Announcements.Commands.Delete;
using Application.Features.Announcements.Commands.Update;
using Application.Features.Announcements.Queries.GetById;
using Application.Features.Announcements.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Authors.Queries.FilterSearch;
using Domain.Entities;
using Application.Features.Announcements.Queries.FilterSearch;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnnouncementsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromForm] CreateAnnouncementCommand createAnnouncementCommand)
    {
        CreatedAnnouncementResponse response = await Mediator.Send(createAnnouncementCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromForm] UpdateAnnouncementCommand updateAnnouncementCommand)
    {
        UpdatedAnnouncementResponse response = await Mediator.Send(updateAnnouncementCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedAnnouncementResponse response = await Mediator.Send(new DeleteAnnouncementCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdAnnouncementResponse response = await Mediator.Send(new GetByIdAnnouncementQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListAnnouncementQuery getListAnnouncementQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListAnnouncementListItemDto> response = await Mediator.Send(getListAnnouncementQuery);
        return Ok(response);
    }
    [HttpGet("search")]
    public async Task<IActionResult> SearchAuthors(
   [FromQuery(Name = "AnnouncementTitle")] string? announcementTitle,  // nullable
   [FromQuery] PageRequest pageRequest)
    {
        // Arama kriterleri oluþtur
        var searchCriteria = new SearchCriteria
        {
           AnnouncementTitle = announcementTitle,
        };

        // MediatR query'sini oluþtur
        var query = new SearchAnnouncementsQuery(searchCriteria, pageRequest);

        // Query'yi gönder ve sonuçlarý al
        var result = await Mediator.Send(query);

        return Ok(result);
    }
}
using Application.Features.Publishers.Commands.Create;
using Application.Features.Publishers.Commands.Delete;
using Application.Features.Publishers.Commands.Update;
using Application.Features.Publishers.Queries.GetById;
using Application.Features.Publishers.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Features.Publishers.Queries.FilterSearch;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PublishersController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePublisherCommand createPublisherCommand)
    {
        CreatedPublisherResponse response = await Mediator.Send(createPublisherCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePublisherCommand updatePublisherCommand)
    {
        UpdatedPublisherResponse response = await Mediator.Send(updatePublisherCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedPublisherResponse response = await Mediator.Send(new DeletePublisherCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdPublisherResponse response = await Mediator.Send(new GetByIdPublisherQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPublisherQuery getListPublisherQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListPublisherListItemDto> response = await Mediator.Send(getListPublisherQuery);
        return Ok(response);
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchPublishers(
    [FromQuery(Name = "PublisherName")] string? publisherName,  // nullable
    [FromQuery(Name = "PublisherLanguage")] string? publisherLanguage,  // nullable
    [FromQuery] PageRequest pageRequest)
    {
        // Arama kriterleri oluþtur
        var searchCriteria = new SearchCriteria
        {
             PublisherName = publisherName,
             PublisherLanguage = publisherLanguage,
        };

        // MediatR query'sini oluþtur
        var query = new SearchPublishersQuery(searchCriteria, pageRequest);

        // Query'yi gönder ve sonuçlarý al
        var result = await Mediator.Send(query);

        return Ok(result);
    }
}
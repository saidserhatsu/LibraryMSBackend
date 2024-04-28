using Application.Features.Locations.Commands.Create;
using Application.Features.Locations.Commands.Delete;
using Application.Features.Locations.Commands.Update;
using Application.Features.Locations.Queries.GetById;
using Application.Features.Locations.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Publishers.Queries.FilterSearch;
using Domain.Entities;
using Application.Features.Locations.Queries.FilterSearch;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLocationCommand createLocationCommand)
    {
        CreatedLocationResponse response = await Mediator.Send(createLocationCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLocationCommand updateLocationCommand)
    {
        UpdatedLocationResponse response = await Mediator.Send(updateLocationCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedLocationResponse response = await Mediator.Send(new DeleteLocationCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdLocationResponse response = await Mediator.Send(new GetByIdLocationQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListLocationQuery getListLocationQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListLocationListItemDto> response = await Mediator.Send(getListLocationQuery);
        return Ok(response);
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchLocations(
    [FromQuery(Name = "LocationsName")] string? locationsName,  // nullable
    [FromQuery(Name = "LocationsShelfName")] string? locationsShelfName,  // nullable
    [FromQuery] PageRequest pageRequest)
    {
        // Arama kriterleri oluþtur
        var searchCriteria = new SearchCriteria
        {
             LocationsName = locationsName,
             LocationsShelfName = locationsShelfName,
        };

        // MediatR query'sini oluþtur
        var query = new SearchLocationsQuery(searchCriteria, pageRequest); 

        // Query'yi gönder ve sonuçlarý al
        var result = await Mediator.Send(query);

        return Ok(result);
    }
}
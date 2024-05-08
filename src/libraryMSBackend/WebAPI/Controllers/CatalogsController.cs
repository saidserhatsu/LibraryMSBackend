using Application.Features.Catalogs.Commands.Create;
using Application.Features.Catalogs.Commands.Delete;
using Application.Features.Catalogs.Commands.Update;
using Application.Features.Catalogs.Queries.GetById;
using Application.Features.Catalogs.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Categories.Queries.FilterSearch;
using Domain.Entities;
using Application.Features.Catalogs.Queries.FilterSearch;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CatalogsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromForm] CreateCatalogCommand createCatalogCommand)
    {
        CreatedCatalogResponse response = await Mediator.Send(createCatalogCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromForm] UpdateCatalogCommand updateCatalogCommand)
    {
        UpdatedCatalogResponse response = await Mediator.Send(updateCatalogCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedCatalogResponse response = await Mediator.Send(new DeleteCatalogCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdCatalogResponse response = await Mediator.Send(new GetByIdCatalogQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListCatalogQuery getListCatalogQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListCatalogListItemDto> response = await Mediator.Send(getListCatalogQuery);
        return Ok(response);
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchCatalogs(
   [FromQuery(Name = "Name")] string? name,  // nullable
   [FromQuery] PageRequest pageRequest)
    {
        // Arama kriterleri oluþtur
        var searchCriteria = new SearchCriteria
        {
            CatalogName = name
        };

        // MediatR query'sini oluþtur
        var query = new SearchCatalogsQuery(searchCriteria, pageRequest);

        // Query'yi gönder ve sonuçlarý al
        var result = await Mediator.Send(query);

        return Ok(result);
    }
}
using Application.Features.CatalogManagements.Commands.Create;
using Application.Features.CatalogManagements.Commands.Delete;
using Application.Features.CatalogManagements.Commands.Update;
using Application.Features.CatalogManagements.Queries.GetById;
using Application.Features.CatalogManagements.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CatalogManagementsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCatalogManagementCommand createCatalogManagementCommand)
    {
        CreatedCatalogManagementResponse response = await Mediator.Send(createCatalogManagementCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCatalogManagementCommand updateCatalogManagementCommand)
    {
        UpdatedCatalogManagementResponse response = await Mediator.Send(updateCatalogManagementCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedCatalogManagementResponse response = await Mediator.Send(new DeleteCatalogManagementCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdCatalogManagementResponse response = await Mediator.Send(new GetByIdCatalogManagementQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListCatalogManagementQuery getListCatalogManagementQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListCatalogManagementListItemDto> response = await Mediator.Send(getListCatalogManagementQuery);
        return Ok(response);
    }
}
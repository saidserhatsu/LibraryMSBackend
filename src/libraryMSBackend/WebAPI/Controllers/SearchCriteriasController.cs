using Application.Features.SearchCriterias.Commands.Create;
using Application.Features.SearchCriterias.Commands.Delete;
using Application.Features.SearchCriterias.Commands.Update;
using Application.Features.SearchCriterias.Queries.GetById;
using Application.Features.SearchCriterias.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SearchCriteriasController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSearchCriteriaCommand createSearchCriteriaCommand)
    {
        CreatedSearchCriteriaResponse response = await Mediator.Send(createSearchCriteriaCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSearchCriteriaCommand updateSearchCriteriaCommand)
    {
        UpdatedSearchCriteriaResponse response = await Mediator.Send(updateSearchCriteriaCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedSearchCriteriaResponse response = await Mediator.Send(new DeleteSearchCriteriaCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdSearchCriteriaResponse response = await Mediator.Send(new GetByIdSearchCriteriaQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListSearchCriteriaQuery getListSearchCriteriaQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListSearchCriteriaListItemDto> response = await Mediator.Send(getListSearchCriteriaQuery);
        return Ok(response);
    }
}
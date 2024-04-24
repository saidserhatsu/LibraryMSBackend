using Application.Features.Materials.Commands.Create;
using Application.Features.Materials.Commands.Delete;
using Application.Features.Materials.Commands.Update;
using Application.Features.Materials.Queries.GetById;
using Application.Features.Materials.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Features.Materials.Queries.FilterSearch;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MaterialsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateMaterialCommand createMaterialCommand)
    {
        CreatedMaterialResponse response = await Mediator.Send(createMaterialCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateMaterialCommand updateMaterialCommand)
    {
        UpdatedMaterialResponse response = await Mediator.Send(updateMaterialCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedMaterialResponse response = await Mediator.Send(new DeleteMaterialCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdMaterialResponse response = await Mediator.Send(new GetByIdMaterialQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListMaterialQuery getListMaterialQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListMaterialListItemDto> response = await Mediator.Send(getListMaterialQuery);
        return Ok(response);
    }

    //[HttpGet("search")]
    //public async Task<IActionResult> SearchMaterials([FromQuery] SearchCriteria criteria, [FromQuery] PageRequest pageRequest)
    //{
    //    // MediatR query'sini çaðýrýn
    //    var query = new SearchMaterialsQuery(criteria, pageRequest);
    //    var result = await Mediator.Send(query);

    //    return Ok(result);
    //}


    [HttpGet("search")]
    public async Task<IActionResult> SearchMaterials([FromQuery(Name = "MaterialName")] string materialName, [FromQuery] PageRequest pageRequest)
    {
        // Sadece MaterialName ve PageRequest parametreleriyle arama yapýn
        SearchMaterialsQuery query = new SearchMaterialsQuery(new SearchCriteria { MaterialName = materialName }, pageRequest);

        var result = await Mediator.Send(query);
        return Ok(result);
    }

}

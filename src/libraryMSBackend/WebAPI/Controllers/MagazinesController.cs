using Application.Features.Magazines.Commands.Create;
using Application.Features.Magazines.Commands.Delete;
using Application.Features.Magazines.Commands.Update;
using Application.Features.Magazines.Queries.GetById;
using Application.Features.Magazines.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Features.Materials.Queries.FilterSearch;
using MediatR;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MagazinesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateMagazineCommand createMagazineCommand)
    {
        CreatedMagazineResponse response = await Mediator.Send(createMagazineCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateMagazineCommand updateMagazineCommand)
    {
        UpdatedMagazineResponse response = await Mediator.Send(updateMagazineCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedMagazineResponse response = await Mediator.Send(new DeleteMagazineCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdMagazineResponse response = await Mediator.Send(new GetByIdMagazineQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListMagazineQuery getListMagazineQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListMagazineListItemDto> response = await Mediator.Send(getListMagazineQuery);
        return Ok(response);
    }

    //[HttpGet("search")]
    //public async Task<IActionResult> SearchMagazines([FromQuery] SearchCriteria criteria, [FromQuery] PageRequest pageRequest)
    //{
    //    // MediatR query'sini çaðýrýn
    //    var query = new SearchMagazinesQuery(criteria, pageRequest);
    //    var result = await Mediator.Send(query);

    //    return Ok(result);
    //}

    //[HttpGet("search")]
    //public async Task<IActionResult> SearchMagazines(
    //[FromQuery(Name = "MagazineTitle")] string magazineTitle,
    //[FromQuery(Name = "MagazineISSNCode")] string magazineISSNCode,
    //[FromQuery] PageRequest pageRequest)
    //{
    //    // MediatR query'sini çaðýrýn
    //    var query = new SearchMagazinesQuery(
    //        new SearchCriteria
    //        {
    //            MagazineTitle = magazineTitle,
    //            MagazineISSNCode = magazineISSNCode
    //        },
    //        pageRequest
    //    );

    //    var result = await Mediator.Send(query);

    //    return Ok(result);
    //}
    [HttpGet("search")]
    public async Task<IActionResult> SearchMagazines(
    [FromQuery(Name = "MagazineTitle")] string? magazineTitle,  // nullable
    [FromQuery(Name = "MagazineISSNCode")] string? magazineISSNCode,  // nullable
    [FromQuery] PageRequest pageRequest)
    {
        // Arama kriterleri oluþtur
        var searchCriteria = new SearchCriteria
        {
            MagazineTitle = magazineTitle,
            MagazineISSNCode = magazineISSNCode
        };

        // MediatR query'sini oluþtur
        var query = new SearchMagazinesQuery(searchCriteria, pageRequest);

        // Query'yi gönder ve sonuçlarý al
        var result = await Mediator.Send(query);

        return Ok(result);
    }
}
//[HttpGet("search")]
//public async Task<IActionResult> SearchMaterials([FromQuery(Name = "MaterialName")] string materialName, [FromQuery] PageRequest pageRequest)
//{
//    // Sadece MaterialName ve PageRequest parametreleriyle arama yapýn
//    SearchMaterialsQuery query = new SearchMaterialsQuery(new SearchCriteria { MaterialName = materialName }, pageRequest);

//    var result = await Mediator.Send(query);
//    return Ok(result);
//}
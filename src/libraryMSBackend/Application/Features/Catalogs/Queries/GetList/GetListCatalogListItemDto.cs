using Application.Features.Books.Queries.GetList;
using Application.Features.CatalogManagements.Queries.GetList;
using Application.Features.Magazines.Queries.GetList;
using Application.Features.Materials.Queries.GetList;
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Catalogs.Queries.GetList;

public class GetListCatalogListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }


    public List<GetListCatalogBook> Books { get; set; }
    public List<GetListMagazineListItemDto> Magazines { get; set; }
    public List<GetListMaterialListItemDto> Materials { get; set; }
}
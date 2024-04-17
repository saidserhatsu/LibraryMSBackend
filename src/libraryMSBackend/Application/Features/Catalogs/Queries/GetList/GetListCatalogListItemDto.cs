using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Catalogs.Queries.GetList;

public class GetListCatalogListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
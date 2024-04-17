using NArchitecture.Core.Application.Dtos;
using Domain.Enums;

namespace Application.Features.Materials.Queries.GetList;

public class GetListMaterialListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public MaterialTypes MaterialType { get; set; }
    public int ReleaseDate { get; set; }
    public Guid PublisherId { get; set; }
    public int? CategoryId { get; set; }
    public Guid? CatalogId { get; set; }
}
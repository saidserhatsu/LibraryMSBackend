using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Locations.Queries.GetList;

public class GetListLocationListItemDto : IDto
{
    public Guid Id { get; set; }
    public int ShelfNo { get; set; }
    public int FloorNo { get; set; }
    public string ShelfName { get; set; }
    public string LibraryName { get; set; }
}
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Locations.Queries.GetById;

public class GetByIdLocationResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int ShelfNo { get; set; }
    public int FloorNo { get; set; }
    public string ShelfName { get; set; }
}
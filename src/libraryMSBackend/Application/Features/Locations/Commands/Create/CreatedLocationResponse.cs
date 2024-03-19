using NArchitecture.Core.Application.Responses;

namespace Application.Features.Locations.Commands.Create;

public class CreatedLocationResponse : IResponse
{
    public Guid Id { get; set; }
    public int ShelfNo { get; set; }
    public int FloorNo { get; set; }
    public string ShelfName { get; set; }
    public string LibraryName { get; set; }
}
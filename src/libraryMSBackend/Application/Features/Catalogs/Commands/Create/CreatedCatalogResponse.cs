using NArchitecture.Core.Application.Responses;

namespace Application.Features.Catalogs.Commands.Create;

public class CreatedCatalogResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
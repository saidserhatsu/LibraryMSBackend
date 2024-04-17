using NArchitecture.Core.Application.Responses;

namespace Application.Features.Catalogs.Commands.Update;

public class UpdatedCatalogResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
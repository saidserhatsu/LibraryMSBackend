using NArchitecture.Core.Application.Responses;

namespace Application.Features.Catalogs.Queries.GetById;

public class GetByIdCatalogResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Catalogs.Commands.Delete;

public class DeletedCatalogResponse : IResponse
{
    public Guid Id { get; set; }
}
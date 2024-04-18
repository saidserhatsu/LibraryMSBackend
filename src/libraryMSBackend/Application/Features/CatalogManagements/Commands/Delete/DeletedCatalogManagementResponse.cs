using NArchitecture.Core.Application.Responses;

namespace Application.Features.CatalogManagements.Commands.Delete;

public class DeletedCatalogManagementResponse : IResponse
{
    public Guid Id { get; set; }
}
using NArchitecture.Core.Application.Responses;

namespace Application.Features.CatalogManagements.Commands.Update;

public class UpdatedCatalogManagementResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid? MaterialId { get; set; }
    public Guid? BookId { get; set; }
    public Guid? MagazineId { get; set; }
    public Guid CatalogId { get; set; }
}
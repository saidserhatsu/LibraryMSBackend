using NArchitecture.Core.Application.Responses;

namespace Application.Features.MagazineAuthors.Queries.GetById;

public class GetByIdMagazineAuthorResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid MagazineId { get; set; }
    public Guid AuthorId { get; set; }
}
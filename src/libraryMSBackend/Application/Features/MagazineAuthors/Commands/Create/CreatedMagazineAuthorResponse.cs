using NArchitecture.Core.Application.Responses;

namespace Application.Features.MagazineAuthors.Commands.Create;

public class CreatedMagazineAuthorResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid MagazineId { get; set; }
    public Guid AuthorId { get; set; }
}
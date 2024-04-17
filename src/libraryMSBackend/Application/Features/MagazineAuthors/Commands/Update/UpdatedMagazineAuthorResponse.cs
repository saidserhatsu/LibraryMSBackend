using NArchitecture.Core.Application.Responses;

namespace Application.Features.MagazineAuthors.Commands.Update;

public class UpdatedMagazineAuthorResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid MagazineId { get; set; }
    public Guid AuthorId { get; set; }
}
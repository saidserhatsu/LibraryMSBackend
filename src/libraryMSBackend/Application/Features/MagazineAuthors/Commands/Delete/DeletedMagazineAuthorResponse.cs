using NArchitecture.Core.Application.Responses;

namespace Application.Features.MagazineAuthors.Commands.Delete;

public class DeletedMagazineAuthorResponse : IResponse
{
    public Guid Id { get; set; }
}
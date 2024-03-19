using NArchitecture.Core.Application.Responses;

namespace Application.Features.BookAuthors.Commands.Delete;

public class DeletedBookAuthorResponse : IResponse
{
    public Guid Id { get; set; }
}
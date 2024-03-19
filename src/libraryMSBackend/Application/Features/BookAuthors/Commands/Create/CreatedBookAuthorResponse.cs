using NArchitecture.Core.Application.Responses;

namespace Application.Features.BookAuthors.Commands.Create;

public class CreatedBookAuthorResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid AuthorId { get; set; }
}
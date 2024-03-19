using NArchitecture.Core.Application.Responses;

namespace Application.Features.BookAuthors.Commands.Update;

public class UpdatedBookAuthorResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid AuthorId { get; set; }
}
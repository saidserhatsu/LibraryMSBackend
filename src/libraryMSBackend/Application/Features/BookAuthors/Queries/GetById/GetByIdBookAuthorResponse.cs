using NArchitecture.Core.Application.Responses;

namespace Application.Features.BookAuthors.Queries.GetById;

public class GetByIdBookAuthorResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid AuthorId { get; set; }
}
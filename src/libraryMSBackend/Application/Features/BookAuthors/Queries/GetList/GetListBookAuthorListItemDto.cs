using NArchitecture.Core.Application.Dtos;

namespace Application.Features.BookAuthors.Queries.GetList;

public class GetListBookAuthorListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid AuthorId { get; set; }
}
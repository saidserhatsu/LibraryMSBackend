using NArchitecture.Core.Application.Dtos;

namespace Application.Features.BookAuthors.Queries.GetList;

public class GetListBookAuthorListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string BookBookTitle { get; set; }
    public Guid AuthorId { get; set; }
    public string AuthorFirstName { get; set; } 
    public string AuthorLastName { get; set; } 
}
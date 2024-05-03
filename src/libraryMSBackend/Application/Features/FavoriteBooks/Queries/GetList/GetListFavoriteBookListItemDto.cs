using NArchitecture.Core.Application.Dtos;

namespace Application.Features.FavoriteBooks.Queries.GetList;

public class GetListFavoriteBookListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string BookBookTitle { get; set; }
    public Guid MemberId { get; set; }
    public string MemberFirstName { get; set; }
    public string MemberLastName { get; set; }
}
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.FavoriteBooks.Queries.GetList;

public class GetListFavoriteBookListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
}
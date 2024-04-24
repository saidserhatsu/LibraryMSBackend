using NArchitecture.Core.Application.Responses;

namespace Application.Features.FavoriteBooks.Commands.Update;

public class UpdatedFavoriteBookResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
}
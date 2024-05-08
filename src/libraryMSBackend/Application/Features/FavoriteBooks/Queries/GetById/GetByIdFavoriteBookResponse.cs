using NArchitecture.Core.Application.Responses;

namespace Application.Features.FavoriteBooks.Queries.GetById;

public class GetByIdFavoriteBookResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string BookBookTitle { get; set; }
    public Guid MemberId { get; set; }
    public string MemberFirstName { get; set; }
    public string MemberLastName { get; set; }
}
using NArchitecture.Core.Application.Responses;

namespace Application.Features.FavoriteBooks.Commands.Delete;

public class DeletedFavoriteBookResponse : IResponse
{
    public Guid Id { get; set; }
}
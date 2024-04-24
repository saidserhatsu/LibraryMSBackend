using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IFavoriteBookRepository : IAsyncRepository<FavoriteBook, Guid>, IRepository<FavoriteBook, Guid>
{
}
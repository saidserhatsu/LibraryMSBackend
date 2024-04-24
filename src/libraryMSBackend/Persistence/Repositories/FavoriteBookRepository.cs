using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class FavoriteBookRepository : EfRepositoryBase<FavoriteBook, Guid, BaseDbContext>, IFavoriteBookRepository
{
    public FavoriteBookRepository(BaseDbContext context) : base(context)
    {
    }
}
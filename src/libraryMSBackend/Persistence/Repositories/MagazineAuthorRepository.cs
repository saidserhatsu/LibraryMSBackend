using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class MagazineAuthorRepository : EfRepositoryBase<MagazineAuthor, Guid, BaseDbContext>, IMagazineAuthorRepository
{
    public MagazineAuthorRepository(BaseDbContext context) : base(context)
    {
    }
}
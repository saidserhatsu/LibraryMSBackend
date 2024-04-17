using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class CatalogRepository : EfRepositoryBase<Catalog, Guid, BaseDbContext>, ICatalogRepository
{
    public CatalogRepository(BaseDbContext context) : base(context)
    {
    }
}
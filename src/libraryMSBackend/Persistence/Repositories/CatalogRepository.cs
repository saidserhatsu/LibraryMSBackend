using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class CatalogRepository : EfRepositoryBase<Catalog, Guid, BaseDbContext>, ICatalogRepository
{
    public CatalogRepository(BaseDbContext context) : base(context)
    {
    }
    private DbSet<Catalog> Catalogs => Context.Set<Catalog>(); // DbSet eriþimi

    public IQueryable<Catalog> Table => Catalogs.AsQueryable(); // IQueryable eriþimi
    public async Task<int> CountAsync()
    {
        // Kitap sayýsýný saymak için gerekli kod
        return await Context.Catalogs.CountAsync();
    }
}
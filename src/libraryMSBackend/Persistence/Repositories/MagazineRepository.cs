using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Nest;
using Persistence.Contexts;
using static System.Reflection.Metadata.BlobBuilder;

namespace Persistence.Repositories;

public class MagazineRepository : EfRepositoryBase<Magazine, Guid, BaseDbContext>, IMagazineRepository
{
    public MagazineRepository(BaseDbContext context) : base(context)
    {
    }

    //public IQueryable<Magazine> Table => throw new NotImplementedException();

    private DbSet<Magazine> Magazines => Context.Set<Magazine>(); // DbSet eriþimi

    public IQueryable<Magazine> Table => Magazines.AsQueryable(); // IQueryable eriþimi
    public async Task<int> CountAsync()
    {
        // Kitap sayýsýný saymak için gerekli kod
        return await Context.Magazines.CountAsync();
    }
}

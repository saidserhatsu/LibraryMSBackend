using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class MaterialRepository : EfRepositoryBase<Material, Guid, BaseDbContext>, IMaterialRepository
{
    public MaterialRepository(BaseDbContext context) : base(context)
    {
    }

    private DbSet<Material> Materials => Context.Set<Material>(); // DbSet eriþimi

    public IQueryable<Material> Table => Materials.AsQueryable(); // IQueryable eriþimi
}
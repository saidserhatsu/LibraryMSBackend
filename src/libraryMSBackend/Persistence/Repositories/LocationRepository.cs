using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class LocationRepository : EfRepositoryBase<Location, Guid, BaseDbContext>, ILocationRepository
{
    public LocationRepository(BaseDbContext context) : base(context)
    {
    }

    private DbSet<Location> Locations => Context.Set<Location>(); // DbSet eriþimi

    public IQueryable<Location> Table => Locations.AsQueryable(); // IQueryable eriþimi
}
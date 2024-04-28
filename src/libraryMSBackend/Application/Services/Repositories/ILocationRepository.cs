using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ILocationRepository : IAsyncRepository<Location, Guid>, IRepository<Location, Guid>
{
    IQueryable<Location> Table { get; } // Bu özellik, IQueryable eriþimini saðlar.
}
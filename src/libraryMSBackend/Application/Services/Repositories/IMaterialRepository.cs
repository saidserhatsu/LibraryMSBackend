using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IMaterialRepository : IAsyncRepository<Material, Guid>, IRepository<Material, Guid>
{
    IQueryable<Material> Table { get; } // Bu �zellik, IQueryable eri�imini sa�lar.
}
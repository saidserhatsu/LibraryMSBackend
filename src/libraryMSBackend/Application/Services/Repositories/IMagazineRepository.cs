using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IMagazineRepository : IAsyncRepository<Magazine, Guid>, IRepository<Magazine, Guid>
{
    IQueryable<Magazine> Table { get; } // Bu �zellik, IQueryable eri�imini sa�lar.
    Task<int> CountAsync();
}
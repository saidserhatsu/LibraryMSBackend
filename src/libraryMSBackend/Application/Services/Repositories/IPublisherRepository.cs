using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IPublisherRepository : IAsyncRepository<Publisher, Guid>, IRepository<Publisher, Guid>
{
    IQueryable<Publisher> Table { get; } // Bu �zellik, IQueryable eri�imini sa�lar.
}
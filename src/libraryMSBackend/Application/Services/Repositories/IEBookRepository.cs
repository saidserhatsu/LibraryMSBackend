using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IEBookRepository : IAsyncRepository<EBook, Guid>, IRepository<EBook, Guid>
{
    IQueryable<EBook> Table { get; } // Bu �zellik, IQueryable eri�imini sa�lar.
}
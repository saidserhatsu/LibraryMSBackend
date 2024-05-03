using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IFineDueRepository : IAsyncRepository<FineDue, Guid>, IRepository<FineDue, Guid>
{
    IQueryable<FineDue> Table { get; } // Bu özellik, IQueryable eriþimini saðlar.
}
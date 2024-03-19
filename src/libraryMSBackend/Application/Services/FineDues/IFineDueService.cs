using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.FineDues;

public interface IFineDueService
{
    Task<FineDue?> GetAsync(
        Expression<Func<FineDue, bool>> predicate,
        Func<IQueryable<FineDue>, IIncludableQueryable<FineDue, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<FineDue>?> GetListAsync(
        Expression<Func<FineDue, bool>>? predicate = null,
        Func<IQueryable<FineDue>, IOrderedQueryable<FineDue>>? orderBy = null,
        Func<IQueryable<FineDue>, IIncludableQueryable<FineDue, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<FineDue> AddAsync(FineDue fineDue);
    Task<FineDue> UpdateAsync(FineDue fineDue);
    Task<FineDue> DeleteAsync(FineDue fineDue, bool permanent = false);
}

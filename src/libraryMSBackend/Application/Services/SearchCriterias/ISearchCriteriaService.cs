using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.SearchCriterias;

public interface ISearchCriteriaService
{
    Task<SearchCriteria?> GetAsync(
        Expression<Func<SearchCriteria, bool>> predicate,
        Func<IQueryable<SearchCriteria>, IIncludableQueryable<SearchCriteria, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<SearchCriteria>?> GetListAsync(
        Expression<Func<SearchCriteria, bool>>? predicate = null,
        Func<IQueryable<SearchCriteria>, IOrderedQueryable<SearchCriteria>>? orderBy = null,
        Func<IQueryable<SearchCriteria>, IIncludableQueryable<SearchCriteria, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<SearchCriteria> AddAsync(SearchCriteria searchCriteria);
    Task<SearchCriteria> UpdateAsync(SearchCriteria searchCriteria);
    Task<SearchCriteria> DeleteAsync(SearchCriteria searchCriteria, bool permanent = false);
}

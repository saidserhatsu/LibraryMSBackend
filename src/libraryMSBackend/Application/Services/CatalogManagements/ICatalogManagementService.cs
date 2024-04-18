using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.CatalogManagements;

public interface ICatalogManagementService
{
    Task<CatalogManagement?> GetAsync(
        Expression<Func<CatalogManagement, bool>> predicate,
        Func<IQueryable<CatalogManagement>, IIncludableQueryable<CatalogManagement, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<CatalogManagement>?> GetListAsync(
        Expression<Func<CatalogManagement, bool>>? predicate = null,
        Func<IQueryable<CatalogManagement>, IOrderedQueryable<CatalogManagement>>? orderBy = null,
        Func<IQueryable<CatalogManagement>, IIncludableQueryable<CatalogManagement, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<CatalogManagement> AddAsync(CatalogManagement catalogManagement);
    Task<CatalogManagement> UpdateAsync(CatalogManagement catalogManagement);
    Task<CatalogManagement> DeleteAsync(CatalogManagement catalogManagement, bool permanent = false);
}

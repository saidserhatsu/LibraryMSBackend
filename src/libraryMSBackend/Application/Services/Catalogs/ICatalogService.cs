using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Catalogs;

public interface ICatalogService
{
    Task<Catalog?> GetAsync(
        Expression<Func<Catalog, bool>> predicate,
        Func<IQueryable<Catalog>, IIncludableQueryable<Catalog, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<Catalog>?> GetListAsync(
        Expression<Func<Catalog, bool>>? predicate = null,
        Func<IQueryable<Catalog>, IOrderedQueryable<Catalog>>? orderBy = null,
        Func<IQueryable<Catalog>, IIncludableQueryable<Catalog, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<Catalog> AddAsync(Catalog catalog);
    Task<Catalog> UpdateAsync(Catalog catalog);
    Task<Catalog> DeleteAsync(Catalog catalog, bool permanent = false);
}

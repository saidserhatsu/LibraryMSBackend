using Application.Features.Catalogs.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Catalogs;

public class CatalogManager : ICatalogService
{
    private readonly ICatalogRepository _catalogRepository;
    private readonly CatalogBusinessRules _catalogBusinessRules;

    public CatalogManager(ICatalogRepository catalogRepository, CatalogBusinessRules catalogBusinessRules)
    {
        _catalogRepository = catalogRepository;
        _catalogBusinessRules = catalogBusinessRules;
    }

    public async Task<Catalog?> GetAsync(
        Expression<Func<Catalog, bool>> predicate,
        Func<IQueryable<Catalog>, IIncludableQueryable<Catalog, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        Catalog? catalog = await _catalogRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return catalog;
    }

    public async Task<IPaginate<Catalog>?> GetListAsync(
        Expression<Func<Catalog, bool>>? predicate = null,
        Func<IQueryable<Catalog>, IOrderedQueryable<Catalog>>? orderBy = null,
        Func<IQueryable<Catalog>, IIncludableQueryable<Catalog, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<Catalog> catalogList = await _catalogRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return catalogList;
    }

    public async Task<Catalog> AddAsync(Catalog catalog)
    {
        Catalog addedCatalog = await _catalogRepository.AddAsync(catalog);

        return addedCatalog;
    }

    public async Task<Catalog> UpdateAsync(Catalog catalog)
    {
        Catalog updatedCatalog = await _catalogRepository.UpdateAsync(catalog);

        return updatedCatalog;
    }

    public async Task<Catalog> DeleteAsync(Catalog catalog, bool permanent = false)
    {
        Catalog deletedCatalog = await _catalogRepository.DeleteAsync(catalog);

        return deletedCatalog;
    }
}

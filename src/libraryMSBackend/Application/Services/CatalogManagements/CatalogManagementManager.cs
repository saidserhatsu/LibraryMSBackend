using Application.Features.CatalogManagements.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.CatalogManagements;

public class CatalogManagementManager : ICatalogManagementService
{
    private readonly ICatalogManagementRepository _catalogManagementRepository;
    private readonly CatalogManagementBusinessRules _catalogManagementBusinessRules;

    public CatalogManagementManager(ICatalogManagementRepository catalogManagementRepository, CatalogManagementBusinessRules catalogManagementBusinessRules)
    {
        _catalogManagementRepository = catalogManagementRepository;
        _catalogManagementBusinessRules = catalogManagementBusinessRules;
    }

    public async Task<CatalogManagement?> GetAsync(
        Expression<Func<CatalogManagement, bool>> predicate,
        Func<IQueryable<CatalogManagement>, IIncludableQueryable<CatalogManagement, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        CatalogManagement? catalogManagement = await _catalogManagementRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return catalogManagement;
    }

    public async Task<IPaginate<CatalogManagement>?> GetListAsync(
        Expression<Func<CatalogManagement, bool>>? predicate = null,
        Func<IQueryable<CatalogManagement>, IOrderedQueryable<CatalogManagement>>? orderBy = null,
        Func<IQueryable<CatalogManagement>, IIncludableQueryable<CatalogManagement, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<CatalogManagement> catalogManagementList = await _catalogManagementRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return catalogManagementList;
    }

    public async Task<CatalogManagement> AddAsync(CatalogManagement catalogManagement)
    {
        CatalogManagement addedCatalogManagement = await _catalogManagementRepository.AddAsync(catalogManagement);

        return addedCatalogManagement;
    }

    public async Task<CatalogManagement> UpdateAsync(CatalogManagement catalogManagement)
    {
        CatalogManagement updatedCatalogManagement = await _catalogManagementRepository.UpdateAsync(catalogManagement);

        return updatedCatalogManagement;
    }

    public async Task<CatalogManagement> DeleteAsync(CatalogManagement catalogManagement, bool permanent = false)
    {
        CatalogManagement deletedCatalogManagement = await _catalogManagementRepository.DeleteAsync(catalogManagement);

        return deletedCatalogManagement;
    }
}

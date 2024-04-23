using Application.Features.SearchCriterias.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.SearchCriterias;

public class SearchCriteriaManager : ISearchCriteriaService
{
    private readonly ISearchCriteriaRepository _searchCriteriaRepository;
    private readonly SearchCriteriaBusinessRules _searchCriteriaBusinessRules;

    public SearchCriteriaManager(ISearchCriteriaRepository searchCriteriaRepository, SearchCriteriaBusinessRules searchCriteriaBusinessRules)
    {
        _searchCriteriaRepository = searchCriteriaRepository;
        _searchCriteriaBusinessRules = searchCriteriaBusinessRules;
    }

    public async Task<SearchCriteria?> GetAsync(
        Expression<Func<SearchCriteria, bool>> predicate,
        Func<IQueryable<SearchCriteria>, IIncludableQueryable<SearchCriteria, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        SearchCriteria? searchCriteria = await _searchCriteriaRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return searchCriteria;
    }

    public async Task<IPaginate<SearchCriteria>?> GetListAsync(
        Expression<Func<SearchCriteria, bool>>? predicate = null,
        Func<IQueryable<SearchCriteria>, IOrderedQueryable<SearchCriteria>>? orderBy = null,
        Func<IQueryable<SearchCriteria>, IIncludableQueryable<SearchCriteria, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<SearchCriteria> searchCriteriaList = await _searchCriteriaRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return searchCriteriaList;
    }

    public async Task<SearchCriteria> AddAsync(SearchCriteria searchCriteria)
    {
        SearchCriteria addedSearchCriteria = await _searchCriteriaRepository.AddAsync(searchCriteria);

        return addedSearchCriteria;
    }

    public async Task<SearchCriteria> UpdateAsync(SearchCriteria searchCriteria)
    {
        SearchCriteria updatedSearchCriteria = await _searchCriteriaRepository.UpdateAsync(searchCriteria);

        return updatedSearchCriteria;
    }

    public async Task<SearchCriteria> DeleteAsync(SearchCriteria searchCriteria, bool permanent = false)
    {
        SearchCriteria deletedSearchCriteria = await _searchCriteriaRepository.DeleteAsync(searchCriteria);

        return deletedSearchCriteria;
    }
}

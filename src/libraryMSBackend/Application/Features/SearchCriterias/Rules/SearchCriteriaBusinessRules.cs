using Application.Features.SearchCriterias.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.SearchCriterias.Rules;

public class SearchCriteriaBusinessRules : BaseBusinessRules
{
    private readonly ISearchCriteriaRepository _searchCriteriaRepository;
    private readonly ILocalizationService _localizationService;

    public SearchCriteriaBusinessRules(ISearchCriteriaRepository searchCriteriaRepository, ILocalizationService localizationService)
    {
        _searchCriteriaRepository = searchCriteriaRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, SearchCriteriasBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task SearchCriteriaShouldExistWhenSelected(SearchCriteria? searchCriteria)
    {
        if (searchCriteria == null)
            await throwBusinessException(SearchCriteriasBusinessMessages.SearchCriteriaNotExists);
    }

    public async Task SearchCriteriaIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        SearchCriteria? searchCriteria = await _searchCriteriaRepository.GetAsync(
            predicate: sc => sc.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await SearchCriteriaShouldExistWhenSelected(searchCriteria);
    }
}
using Application.Features.CatalogManagements.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.CatalogManagements.Rules;

public class CatalogManagementBusinessRules : BaseBusinessRules
{
    private readonly ICatalogManagementRepository _catalogManagementRepository;
    private readonly ILocalizationService _localizationService;

    public CatalogManagementBusinessRules(ICatalogManagementRepository catalogManagementRepository, ILocalizationService localizationService)
    {
        _catalogManagementRepository = catalogManagementRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, CatalogManagementsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task CatalogManagementShouldExistWhenSelected(CatalogManagement? catalogManagement)
    {
        if (catalogManagement == null)
            await throwBusinessException(CatalogManagementsBusinessMessages.CatalogManagementNotExists);
    }

    public async Task CatalogManagementIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        CatalogManagement? catalogManagement = await _catalogManagementRepository.GetAsync(
            predicate: cm => cm.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await CatalogManagementShouldExistWhenSelected(catalogManagement);
    }
}
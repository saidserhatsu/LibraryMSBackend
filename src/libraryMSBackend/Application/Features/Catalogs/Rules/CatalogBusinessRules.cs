using Application.Features.Catalogs.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.Catalogs.Rules;

public class CatalogBusinessRules : BaseBusinessRules
{
    private readonly ICatalogRepository _catalogRepository;
    private readonly ILocalizationService _localizationService;

    public CatalogBusinessRules(ICatalogRepository catalogRepository, ILocalizationService localizationService)
    {
        _catalogRepository = catalogRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, CatalogsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task CatalogShouldExistWhenSelected(Catalog? catalog)
    {
        if (catalog == null)
            await throwBusinessException(CatalogsBusinessMessages.CatalogNotExists);
    }

    public async Task CatalogIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Catalog? catalog = await _catalogRepository.GetAsync(
            predicate: c => c.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await CatalogShouldExistWhenSelected(catalog);
    }
}
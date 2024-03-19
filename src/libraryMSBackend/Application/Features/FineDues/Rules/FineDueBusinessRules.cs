using Application.Features.FineDues.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.FineDues.Rules;

public class FineDueBusinessRules : BaseBusinessRules
{
    private readonly IFineDueRepository _fineDueRepository;
    private readonly ILocalizationService _localizationService;

    public FineDueBusinessRules(IFineDueRepository fineDueRepository, ILocalizationService localizationService)
    {
        _fineDueRepository = fineDueRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, FineDuesBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task FineDueShouldExistWhenSelected(FineDue? fineDue)
    {
        if (fineDue == null)
            await throwBusinessException(FineDuesBusinessMessages.FineDueNotExists);
    }

    public async Task FineDueIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        FineDue? fineDue = await _fineDueRepository.GetAsync(
            predicate: fd => fd.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await FineDueShouldExistWhenSelected(fineDue);
    }
}
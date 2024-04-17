using Application.Features.MagazineAuthors.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.MagazineAuthors.Rules;

public class MagazineAuthorBusinessRules : BaseBusinessRules
{
    private readonly IMagazineAuthorRepository _magazineAuthorRepository;
    private readonly ILocalizationService _localizationService;

    public MagazineAuthorBusinessRules(IMagazineAuthorRepository magazineAuthorRepository, ILocalizationService localizationService)
    {
        _magazineAuthorRepository = magazineAuthorRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, MagazineAuthorsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task MagazineAuthorShouldExistWhenSelected(MagazineAuthor? magazineAuthor)
    {
        if (magazineAuthor == null)
            await throwBusinessException(MagazineAuthorsBusinessMessages.MagazineAuthorNotExists);
    }

    public async Task MagazineAuthorIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        MagazineAuthor? magazineAuthor = await _magazineAuthorRepository.GetAsync(
            predicate: ma => ma.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await MagazineAuthorShouldExistWhenSelected(magazineAuthor);
    }
}
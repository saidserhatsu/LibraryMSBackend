using Application.Features.FavoriteBooks.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.FavoriteBooks.Rules;

public class FavoriteBookBusinessRules : BaseBusinessRules
{
    private readonly IFavoriteBookRepository _favoriteBookRepository;
    private readonly ILocalizationService _localizationService;

    public FavoriteBookBusinessRules(IFavoriteBookRepository favoriteBookRepository, ILocalizationService localizationService)
    {
        _favoriteBookRepository = favoriteBookRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, FavoriteBooksBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task FavoriteBookShouldExistWhenSelected(FavoriteBook? favoriteBook)
    {
        if (favoriteBook == null)
            await throwBusinessException(FavoriteBooksBusinessMessages.FavoriteBookNotExists);
    }

    public async Task FavoriteBookIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        FavoriteBook? favoriteBook = await _favoriteBookRepository.GetAsync(
            predicate: fb => fb.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await FavoriteBookShouldExistWhenSelected(favoriteBook);
    }
}
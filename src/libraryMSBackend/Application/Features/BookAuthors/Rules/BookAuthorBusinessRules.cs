using Application.Features.BookAuthors.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.BookAuthors.Rules;

public class BookAuthorBusinessRules : BaseBusinessRules
{
    private readonly IBookAuthorRepository _bookAuthorRepository;
    private readonly ILocalizationService _localizationService;

    public BookAuthorBusinessRules(IBookAuthorRepository bookAuthorRepository, ILocalizationService localizationService)
    {
        _bookAuthorRepository = bookAuthorRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, BookAuthorsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task BookAuthorShouldExistWhenSelected(BookAuthor? bookAuthor)
    {
        if (bookAuthor == null)
            await throwBusinessException(BookAuthorsBusinessMessages.BookAuthorNotExists);
    }

    public async Task BookAuthorIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        BookAuthor? bookAuthor = await _bookAuthorRepository.GetAsync(
            predicate: ba => ba.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await BookAuthorShouldExistWhenSelected(bookAuthor);
    }
}
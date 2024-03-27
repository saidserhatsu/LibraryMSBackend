using Application.Features.Books.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;
using Application.Features.Members.Constants;

namespace Application.Features.Books.Rules;

public class BookBusinessRules : BaseBusinessRules
{
    private readonly IBookRepository _bookRepository;
    private readonly ILocalizationService _localizationService;

    public BookBusinessRules(IBookRepository bookRepository, ILocalizationService localizationService)
    {
        _bookRepository = bookRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, BooksBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task BookShouldExistWhenSelected(Book? book)
    {
        if (book == null)
            await throwBusinessException(BooksBusinessMessages.BookNotExists);
    }

    public async Task BookIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Book? book = await _bookRepository.GetAsync(
            predicate: b => b.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await BookShouldExistWhenSelected(book);
    }

    public async Task BookISBNCodeCanNotBeDuplicatedWhenInserted(string bookýsnbCode)
    {
        Book? result = await _bookRepository.GetAsync(x => x.ISBNCode == bookýsnbCode);
        if (result != null)
            throw new BusinessException(BooksBusinessMessages.Mevcutdegil);
    }

    public async Task BookISBNCodeCanNotBeDuplicatedWhenUpdated(Book book)
    {
        Book? result = await _bookRepository.GetAsync(x => x.Id != book.Id && x.ISBNCode == book.ISBNCode);
        if (result != null)
            throw new BusinessException(BooksBusinessMessages.Mevcutdegil);
    }
}

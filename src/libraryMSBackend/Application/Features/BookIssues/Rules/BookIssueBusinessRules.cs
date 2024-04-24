using Application.Features.BookIssues.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;
using Application.Features.Auth.Constants;
using Domain.Enums;

namespace Application.Features.BookIssues.Rules;

public class BookIssueBusinessRules : BaseBusinessRules
{
    private readonly IBookIssueRepository _bookIssueRepository;
    private readonly ILocalizationService _localizationService;
    private readonly IBookRepository _bookRepository;

    public BookIssueBusinessRules(IBookIssueRepository bookIssueRepository, ILocalizationService localizationService, IBookRepository bookRepository)
    {
        _bookIssueRepository = bookIssueRepository;
        _localizationService = localizationService;
        _bookRepository = bookRepository;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, BookIssuesBusinessMessages.SectionName);
        throw new BusinessException(message);

        
    }

    public async Task BookIssueShouldExistWhenSelected(BookIssue? bookIssue)
    {
        if (bookIssue == null)
            await throwBusinessException(BookIssuesBusinessMessages.BookIssueNotExists);
    }

    public async Task BookIssueIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        BookIssue? bookIssue = await _bookIssueRepository.GetAsync(
            predicate: bi => bi.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await BookIssueShouldExistWhenSelected(bookIssue);
    }

    public async Task CheckIfMemberHasExceededBookLimit(Guid memberId)
    {
        int maxBookLimit = 3;  // Belirlediðiniz maksimum kitap sayýsý
        var currentBookCount = await _bookIssueRepository.GetBookCountByMemberIdAsync(memberId);

        if (currentBookCount >= maxBookLimit)
        {
            await throwBusinessException(BookIssuesBusinessMessages.BookIssueMaxLimitReached);
        }
    }
    //------------------------------------------------------------------------

    public async Task EnsureBookIsAvailable(Guid bookId)
    {
        var book = await _bookRepository.GetByIdAsync(bookId);

        if (book == null)
        {
            throw new KeyNotFoundException($"Book with ID {bookId} does not exist.");
        }

        if (book.Status == BookStatus.Borrowed || book.Status == BookStatus.Reserved)
        {
            throw new Exception($"The book is currently {book.Status}."); // Replace with a custom exception
        }
    }




    //todo: BusinessRules -> Bir kullanýcý ayný anda en fazla 2-3 kitap alabilir

    //todo: BusinessRules -> Bir kullanýcý bir kitabý 2 hafta içinde iade etmesi gerekir. Aksi taktirde cezai iþlem uygulanýr.
}
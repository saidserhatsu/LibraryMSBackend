using Application.Features.BookIssues.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.BookIssues.Rules;

public class BookIssueBusinessRules : BaseBusinessRules
{
    private readonly IBookIssueRepository _bookIssueRepository;
    private readonly ILocalizationService _localizationService;

    public BookIssueBusinessRules(IBookIssueRepository bookIssueRepository, ILocalizationService localizationService)
    {
        _bookIssueRepository = bookIssueRepository;
        _localizationService = localizationService;
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
    //------------------------------------------------------------------------
   


   


    //todo: BusinessRules -> Bir kullanýcý ayný anda en fazla 2-3 kitap alabilir.
    //todo: BusinessRules -> Bir kullanýcý bir kitabý 2 hafta içinde iade etmesi gerekir. Aksi taktirde cezai iþlem uygulanýr.
}